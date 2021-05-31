using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InClassRazor.Models;

namespace InClassRazor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
        public IActionResult IndexWithLayout()
        {
            return View();
        }
        public IActionResult Contact()
        {
            GuestContact contact = new GuestContact();

            contact.Name = "Nels Matson";
            contact.Email = "nelsmatson@usf.edu";
            contact.Phone = "813-123-4567";




            return View(contact);
        }

        [HttpPost]
        public IActionResult Contact(GuestContact contact)
        {
            return View(contact);
        }
    }
}
    
        
   

