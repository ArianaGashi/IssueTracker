using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace IssueTrackingSystem.Models.IssueBase
{
    public class Labels
    {
        [Key]
        public int LabelId { get; set; }

        [Required]
        public string Name{ get; set; }

        public List<LabelIssues> AllIssuesLabeled{ get; set; }
    }
}