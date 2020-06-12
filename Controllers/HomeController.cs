using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;
namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private int? UserSession
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
            set { HttpContext.Session.SetInt32("UserId", (int)value); }
        }
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreateUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                // Check if email already exists in db
                var existingUser = dbContext.Users.FirstOrDefault(u => u.Email == newUser.Email);
                if (existingUser != null)
                {
                    ModelState.AddModelError("Email", "Email already exists");
                    return View("Index");
                }
                // Hash new user's password and save new user to db
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                UserSession = newUser.UserId;
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser currUser)
        {
            if (ModelState.IsValid)
            {
                // Check if email exists in database
                var existingUser = dbContext.Users.FirstOrDefault(u => u.Email == currUser.Email);
                if (existingUser == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(currUser, existingUser.Password, currUser.Password);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                UserSession = existingUser.UserId;
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            // Redirect to register/login page if no user in session
            if (UserSession == null)
                return RedirectToAction("Index");

            // Get all weddings with included Assossications ordered by date
            var AllWeddings = dbContext.Weddings
                .Include(w => w.Assossications)
                .OrderByDescending(w => w.Date)
                .ToList();
                
            ViewBag.UserId = UserSession;
            return View(AllWeddings);
        }

        [HttpGet("{weddingId}")]
        public IActionResult Show(int weddingId)
        {
            var thisWedding = dbContext.Weddings
            .Include(w => w.Assossications)
            .ThenInclude(r => r.Guest)
            .FirstOrDefault(w => w.WeddingId == weddingId);
            return View(thisWedding);
        }
        
        [HttpGet("New")]
        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost("Make")]
        public IActionResult Make(Wedding newWedding)
        {
            if (UserSession == null)
                    return RedirectToAction("Dashboard");
            if (ModelState.IsValid)
            {   
                // Crete new wedding with UserId set to current session user's id
                newWedding.UserId = (int)UserSession;
                dbContext.Weddings.Add(newWedding);
                dbContext.SaveChanges();
                return Redirect("/"+ newWedding.WeddingId);
            }
            return View("Dashboard");
        }

        [HttpGet("delete/{weddingId}")]
        public IActionResult Delete(int weddingId)
        {
            if (UserSession == null)
                return RedirectToAction("Dashboard");
            Wedding toDelete = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);
            if (toDelete == null)
                return RedirectToAction("Dashboard");
            // Redirect to dashboard if user trying to delete isn't the wedding creator
            if (toDelete.UserId != UserSession)
                return RedirectToAction("Dashboard");
            dbContext.Weddings.Remove(toDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("rsvp/{weddingId}")]
        public IActionResult RSVP(int weddingId)
        {
            Assossication newAssossication = new Assossication()
            {
                WeddingId = weddingId,
                UserId = (int)UserSession
            };
            dbContext.Assossications.Add(newAssossication);
            dbContext.SaveChanges();
            return Redirect("/dashboard");
        }

        [HttpGet("unrsvp/{weddingId}")]
        public IActionResult UnRSVP(int weddingId)
        {
            var toDelete = dbContext.Assossications
                .FirstOrDefault(i=>i.WeddingId == weddingId && i.UserId == (int)UserSession);
            dbContext.Assossications.Remove(toDelete);
            dbContext.SaveChanges();
            return Redirect("/dashboard");
        }
    }
}