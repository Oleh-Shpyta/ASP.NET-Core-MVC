
using Microsoft.AspNetCore.Mvc;
using ContactApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContactApp.Controllers
{
    public class ContactController : Controller
    {
        private static List<Contact> contacts = new List<Contact>();
        private static int nextId = 1;

        public IActionResult Index()
        {
            return View(contacts);
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.Id = nextId++;
                contacts.Add(contact);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                contacts.Remove(contact);
            }
            return RedirectToAction("Index");
        }
    }
}
