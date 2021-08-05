using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignUpPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;


namespace SignUpPage.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
#pragma warning disable IDE0060 // Remove unused parameter
        public IActionResult SignUp(UserModel model)
#pragma warning restore IDE0060 // Remove unused parameter
        {
          

            if (ModelState.IsValid)
            {
                // TO DO:
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
