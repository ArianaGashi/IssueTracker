using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using IssueTrackingSystem.Models.IssueBase;

namespace IssueTrackingSystem.Models.Account
{
    public class Registration
    {
        [Key]

        public int UserId{get;set;}

        [Required]
        [Display(Name="Username")]
        [MinLength(3)]
        public string FirstName{get;set;}

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email{get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password{get;set;}

        public List<Comments> AllIssuesCommented { get; set; } = new List<Comments>();

        public List<UserIssues> AllAssignedIssues { get; set; } = new List<UserIssues>();

    }
}