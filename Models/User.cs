using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    
namespace WeddingPlanner.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        
        [Required(ErrorMessage = "Name must be entered!")]
        [MinLength(4, ErrorMessage = "Must be at least 4 characters")]
        [Display(Name="First Name:")]
        public string FirstName {get;set;}

        [Required(ErrorMessage = "Name must be entered!")]
        [MinLength(4, ErrorMessage = "Must be at least 4 characters")]
        [Display(Name="Last Name:")]
        public string LastName {get;set;}

        [EmailAddress]
        [Required]
        [Display(Name="E-Mail:")]
        public string Email {get;set;}

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [Display(Name="Password:")]
        public string Password {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        // Will not be mapped to your users table!
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
    } 
    public class LoginUser
    {
        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        [Display(Name="E-Mail:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter a password")]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters")]
        [Display(Name="Password:")]
        public string Password { get; set; }
    }
}