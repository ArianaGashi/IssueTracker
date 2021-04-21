using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IssueTrackingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using IssueTrackingSystem.Models.Account;
using IssueTrackingSystem.Models.IssueBase;


namespace IssueTrackingSystem.Controllers
{
    public class HomeController : Controller
    {

        private MyContext _context;
        public static List<Registration> AssignedPeople=new List<Registration>();
        public static List<Labels> AssignLabels = new List<Labels>();

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("Dashboard")]
        public IActionResult Index()
        {
            List<Issue> AllIssues = _context.Issues
                                    .Include(h=>h.Host)
                                    .Include(c => c.AllComments)
                                    .Take(5)
                                    .ToList();

            return View(AllIssues);
        }
        
        [HttpGet("new")]
        public IActionResult NewIssue(){
            ViewBag.Name=HttpContext.Session.GetString("Username");
            ViewBag.Assignes = _context.Registrations.ToList();
            ViewBag.Labels=_context.Labels.ToList();
            AssignedPeople.Clear();
            AssignLabels.Clear();
            return View();
        }

        

        [HttpPost("new")]
        public IActionResult AddIssue(Issue issue){
            ViewBag.Name=HttpContext.Session.GetString("Username");
            ViewBag.Assignes = _context.Registrations.ToList();
            ViewBag.Labels=_context.Labels.ToList();
            int userId = HttpContext.Session.GetInt32("UserId").Value;

            Registration user = _context.Registrations.FirstOrDefault(u => u.UserId ==userId );
            if (ModelState.IsValid) {
                issue.HostId = userId;
                
                    _context.Issues.Add(issue);
                    _context.SaveChanges();

                UserIssues userIssues;
                foreach (var item in AssignedPeople) {
                    Console.WriteLine("Item: "+item.FirstName);
                    userIssues = new UserIssues()
                    {
                        IssueId = issue.id,
                        AssignedId = item.UserId

                    };
                    _context.UserIssues.Add(userIssues);
                }


                //Assigning Labels, it's not working due to IDK
                //There's no LabelLabelId in list but it appears to be one 
                //That's whats making this error 
                //
                //
                //
                //
                //
                //
                
                // LabelIssues labelIssues;

                // foreach (var item in AssignLabels) { 
                //     Console.WriteLine("Item: "+item);
                //     labelIssues = new LabelIssues()
                //     {
                //         IssueId = issue.id,
                //         LabelId =item.LabelId

                //     };
                //     _context.LabelIssues.Add(labelIssues);
                    

                // }
                //
                //
                //
                //
                //

                
                _context.SaveChanges();
                
                AssignedPeople.Clear();
                AssignLabels.Clear();
                Console.WriteLine("Added " + issue.Title);
                return RedirectToAction("IssueDetails", new {id=issue.id});
                
            }
            
            return View("NewIssue");
        }

        public Issue GetIssue(int id) { 

            return _context.Issues
                            .Include(c => c.AllComments)
                            .ThenInclude(h=>h.Host)
                            .Include(u=>u.AllAssigned)
                            .ThenInclude(x=>x.Assigned)
                            .Include(h => h.Host)
                            .FirstOrDefault(i => i.id == id);
        }

        [HttpGet("issue/{id}")]
        public IActionResult IssueDetails(int id){
            ViewBag.Name=HttpContext.Session.GetString("Username");
            ViewBag.Issue = GetIssue(id);
            HttpContext.Session.SetInt32("IssueId",id);

                return View();

            
            // return RedirectToAction("Index");
        }


        [HttpPost("newComment")]

        public IActionResult PostComment(Comments comment) {

            ViewBag.Name=HttpContext.Session.GetString("Username");
            ViewBag.Issue = GetIssue(comment.IssueId);

            if (ModelState.IsValid) {
                comment.HostId = HttpContext.Session.GetInt32("UserId").Value;
                _context.Comments.Add(comment);
                _context.SaveChanges();
                return View("IssueDetails", comment);
            }

            return RedirectToAction("Index");

        }

        [HttpGet("assign")]
        public void AddAssigned(int id) {
            Registration assign = _context.Registrations.FirstOrDefault(u => u.UserId == id);
            if(!AssignedPeople.Any(l=>l.UserId==assign.UserId)){
                AssignedPeople.Add(assign);
            }
        }
        
        [HttpGet("assignlabel")]
        public void Assignlabels(int id) {
            Labels assign = _context.Labels.FirstOrDefault(u => u.LabelId == id);
            if(!AssignLabels.Any(l=>l.LabelId==assign.LabelId)){
                AssignLabels.Add(assign);
            }
        }


        [HttpGet("label")]

        public IActionResult AddLabel(){
            return View();

        }

        [HttpPost("addlabel")]

        public IActionResult AddLabel(Labels label) {

            if(ModelState.IsValid){
                if(!_context.Labels.Any(l=>l.Name==label.Name)){
                    _context.Labels.Add(label);
                    _context.SaveChanges();
                }
            }

            return View("AddLabel");

        }
    [HttpGet("logout")]
    public IActionResult LogOut(){
        HttpContext.Session.Clear();
        return  RedirectToAction("Index","Account");
    }

    // 500 (Internal Server Error) when making the request in  issuedetail.js
        [HttpGet("changestatus")]
        public IActionResult ChangeStatus(string status) {
            Issue issue=_context.Issues.FirstOrDefault(x=>x.id==HttpContext.Session.GetInt32("IssueId").Value);

            if(issue.HostId==HttpContext.Session.GetInt32("UserID").Value){
                if(status =="Closed")
                    issue.Status="Open";
                else 
                issue.Status="Closed"; 
                }
                
            // return status;
            @ViewBag.Issue=issue;
            return View();
        }

    public List<Issue>  FilterIssueByName(string name){

                    return  _context.Issues
                                    .Include(h=>h.Host)
                                    .Include(c => c.AllComments)
                                    .Where(x=>x.Title.ToUpper().Contains(name.ToUpper()))
                                    .Take(10)
                                    .ToList();

    }

    [HttpGet("filterIssue")]

    public IActionResult IssueSearch(string name){

        if(name==null)
                name = "";

        List<Issue> AllIssues =FilterIssueByName(name);

        return View(AllIssues);
    }


    }
    
}
