using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Resume2.Core.Services.Interfaces;
using Resume2.Domain.Models.Auth;

namespace Resume2.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService;
        public UserController(IUserService _userService)
        {
            userService = _userService;
        }
        //Route["users"]
        public IActionResult ShowUser()
        {
            List<User> users = userService.GetUsers();
            return View(users);
        }
        #region CreateUser
        [HttpGet("CreateUser")]
        public ActionResult CreateUser()
        {
            return View(new User());
        }
        [HttpPost("CreateUser")]
        public ActionResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                userService.AddUser(user);
                return RedirectToAction("ShowUser");
            }
            else
            {
                return View(user);
            }

        }
        #endregion
    }
}
