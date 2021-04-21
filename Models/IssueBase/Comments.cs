using System.ComponentModel.DataAnnotations;
using System;
using IssueTrackingSystem.Models.Account;

namespace IssueTrackingSystem.Models.IssueBase
{
    public class Comments
    {
        [Key]

        public int CommentsId{ get; set;}

        [Required]
        [MinLength(3)]
        public string Description{ get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int HostId{get;set; }
        public Registration Host{get;set; }

        public int IssueId{ get; set; }

        public Issue Issue{ get; set; }


    }
}