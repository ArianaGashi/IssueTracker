using System;
using System.ComponentModel.DataAnnotations;


namespace IssueTrackingSystem.Models.Account
{
    public class Login
    {
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email")]
        public string EmailLog{get;set;}
        
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string PasswordLog{get;set;}
    }
}