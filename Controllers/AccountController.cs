using Microsoft.AspNetCore.Mvc;
using IssueTrackingSystem.Models;
using IssueTrackingSystem.Models.Account;
using IssueTrackingSystem.Models.IssueBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System;

namespace IssueTrackingSystem.Controllers
{
    public class AccountController : Controller
    {

        private MyContext _context;
        
        public AccountController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index() {

            return View();

        }


        [HttpPost("register")]
        public IActionResult Register(Registration reg)
        {
            if (ModelState.IsValid) {

                if (_context.Registrations.Any(u => u.Email == reg.Email)) {


                    ModelState.AddModelError("Email", "User with this email already exists");
                    return View("Index");
                }

                PasswordHasher<Registration> hasher = new PasswordHasher<Registration>();
                reg.Password = hasher.HashPassword(reg, reg.Password);


                _context.Registrations.Add(reg);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", reg.UserId);
                HttpContext.Session.SetString("Username", reg.FirstName);
                TempData["Usermane"] = reg.FirstName;
                Console.WriteLine("Registered "+reg.Email);
                return RedirectToAction("Index","Home");

            }

            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid) {

                Registration user=_context.Registrations.FirstOrDefault(u=>u.Email==login.EmailLog);

                if (user == null) { 

                    ModelState.AddModelError("EmailLog","Email does not exists");
                    return View("Index");
                }

                PasswordHasher<Login> passwordHasher = new PasswordHasher<Login>();

                var result = passwordHasher.VerifyHashedPassword(login, user.Password, login.PasswordLog);
                if(result==0){

                    ModelState.AddModelError("PasswordLog","Password did not match");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("UserId", user.UserId);
                HttpContext.Session.SetString("Username", user.FirstName);
                TempData["Usermane"] = user.FirstName;
                Console.WriteLine("Loged in "+login.EmailLog);
                return RedirectToAction("Index","Home");

            }

            return View("Index");
        }

    }
}