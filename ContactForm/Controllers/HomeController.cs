using ContactForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContactForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactModel model)
        {
            return !ModelState.IsValid ? View() : ThankYou(model);
        }

        public IActionResult ThankYou(ContactModel model)
        {
            return View("ThankYou", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
