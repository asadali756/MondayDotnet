using friday.Models;
using Microsoft.AspNetCore.Mvc;
using project.Models;
using System.Diagnostics;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        Connection db = new Connection();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Adddata()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adddata(string name , string email , string password)
        {
            Student std = new Student(name, email, password);
            db.students.Add(std);
            db.SaveChanges();
            return RedirectToAction("Adddata");
        }

        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(string email , string password)
        {
            var data = db.students.Where(x => x.Email == email && password == x.Password).FirstOrDefault();

            if (data!= null)
            {
                HttpContext.Session.SetString("Name", data.Name);

                return RedirectToAction("index");
            }
            return View();
        }

        public IActionResult welcome()
        {
            if (HttpContext.Session.GetString("Name") != null)
            {

            return View();
            }
            else
            {
                return RedirectToAction("login");

            }

        }
            public IActionResult logout()
            {

            HttpContext.Session.Clear();
                return RedirectToAction("index");
            }
    }
}