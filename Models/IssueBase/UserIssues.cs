using System.ComponentModel.DataAnnotations;
using IssueTrackingSystem.Models.Account;

namespace IssueTrackingSystem.Models.IssueBase
{
    public class UserIssues
    {
        [Key]
        public int UserIssueId{ get; set; }

        public int AssignedId{ get; set; }
        public Registration Assigned{ get; set; }

        public int IssueId{ get; set; }
        public Issue Issue{ get; set; }
        
    }
}