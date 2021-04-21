using Microsoft.EntityFrameworkCore;
using IssueTrackingSystem.Models.IssueBase;
using IssueTrackingSystem.Models.Account;


namespace IssueTrackingSystem.Models
{
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Registration> Registrations{ get; set; }

        public DbSet<Comments> Comments{ get; set; }
        public DbSet<Labels> Labels{ get; set; }

        public DbSet<UserIssues> UserIssues{ get; set; }
        public DbSet<LabelIssues> LabelIssues{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
            // modelBuilder.Entity<Comments>()
            //             .HasOne(x => x.Host)
            //             .WithMany(x => x.AllIssuesCommented)
            //             .HasForeignKey(x => x.HostId);

            modelBuilder.Entity<Comments>()
                        .HasOne(x => x.Issue)
                        .WithMany(x => x.AllComments)
                        .HasForeignKey(x => x.IssueId);

            // modelBuilder.Entity<LabelIssues>()
            //             .HasOne(x => x.Issue)
            //             .WithMany(x => x.AllLabels)
            //             .HasForeignKey(x => x.IssueId);

            // modelBuilder.Entity<LabelIssues>()
            //             .HasOne(x => x.Labels)
            //             .WithMany(x => x.AllIssuesLabeled)
            //             .HasForeignKey(x => x.LabelId);

            // modelBuilder.Entity<UserIssues>()
            //             .HasOne(x => x.Assigned)
            //             .WithMany(x => x.AllAssignedIssues)
            //             .HasForeignKey(x => x.AssignedId);

            // modelBuilder.Entity<UserIssues>()
            //             .HasOne(x => x.Issue)
            //             .WithMany(x => x.AllAssigned)
            //             .HasForeignKey(x => x.IssueId);

        }
    }

    

}