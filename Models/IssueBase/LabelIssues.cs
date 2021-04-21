using System.ComponentModel.DataAnnotations;

namespace IssueTrackingSystem.Models.IssueBase
{
    public class LabelIssues
    {
        [Key]
        public int LabelIssueId{ get; set; }

        public int IssueId { get; set; }
        public Issue Issue { get; set; }

        public int LabelId{ get; set; }
        public Labels Labels{ get; set; }
    }
}