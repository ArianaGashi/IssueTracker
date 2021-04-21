using System.ComponentModel.DataAnnotations;
using IssueTrackingSystem.Models.Account;
using System;
using System.Collections.Generic;


namespace IssueTrackingSystem.Models.IssueBase
{
    public class Issue
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MinLength(2)]
        public string Title { get; set; }

        [Required]
        [MinLength(2)]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string Status { get; set; } = "Open";
        public int HostId { get; set; }
        public Registration Host { get; set; }

        public List<UserIssues> AllAssigned { get; set; } = new List<UserIssues>();

        public List<Comments> AllComments { get; set; } = new List<Comments>();

        public List<LabelIssues> AllLabels { get; set; } = new List<LabelIssues>();


    }
}