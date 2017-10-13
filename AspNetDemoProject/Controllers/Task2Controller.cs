using AspNetDemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetDemoProject.Controllers
{
    public class Task2Controller : Controller
    {
        // GET: Task2
        [HttpGet]
        public ActionResult Index()
        {
            // Read from file or DB
            var list = new List<Student>
            {
                new Student
                {
                    Name = "Test",
                    LastName = "Test",
                    BirthDate = DateTime.Today,
                    City = "Almaty",
                    Email = "test@mail.ru"
                }
            };

            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult AddItem(Student data)
        {
            // Save to file or DB
            if (data.Name != null)
            {
                // Save
            }


            return RedirectToAction("Index");
        }
    }
}