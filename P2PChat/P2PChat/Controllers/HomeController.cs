using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P2PChat.Data;
using P2PChat.Services;

namespace P2PChat.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private UserService userService;
        private ApplicationContext applicationContext;

        public HomeController(UserService userService, ApplicationContext appContext)
        {
            this.userService = userService;
            this.applicationContext = appContext;
        }
        public IActionResult Index()
        {
            if (userService.GetCurrentUser() == null)
            {
                return RedirectToAction("Register");
            }
            else
            {
                return View(userService.GetCurrentUser());
            }
        }

        [HttpGet("/register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("/register")]
        public IActionResult Register(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Register");
            }
            userService.Login(username);
            return RedirectToAction("Index");
        }

        [HttpPost("/send")]
        public IActionResult SendMessage(string text)
        {
            userService.SendMessage(text);
            return RedirectToAction("Index");
        }
    }
}