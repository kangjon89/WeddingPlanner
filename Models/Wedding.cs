using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class NoPastDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((DateTime)value <= DateTime.Now)
                return new ValidationResult("Date must be in the future");
            return ValidationResult.Success;
        }
    }

    public class Wedding
    {
        [Key]
        public int WeddingId {get;set;}

        [Required(ErrorMessage = "Name must be entered!")]
        [MinLength(4, ErrorMessage = "Must be at least 4 characters")]
        [Display(Name="Wedder One")]
        public string WedderOne {get;set;}

        [Required(ErrorMessage = "Name must be entered!")]
        [MinLength(4, ErrorMessage = "Must be at least 4 characters")]
        [Display(Name="Wedder Two")]
        public string WedderTwo {get;set;}

        [Required]
        [NoPastDate(ErrorMessage="Date must be a future date")]
        public DateTime Date {get;set;}
        
        [Required(ErrorMessage = "Address must be entered!")]
        [MinLength(4, ErrorMessage = "Must be at least 4 characters")]
        public string Address {get;set;}
        
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
        public int UserId {get;set;}
        public User Planner {get;set;}
        public List<Assossication> Assossications {get;set;}
    }
}