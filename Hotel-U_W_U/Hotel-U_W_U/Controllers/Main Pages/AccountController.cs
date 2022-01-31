using Hotel_U_W_U.Constants;
using Hotel_U_W_U.Models.Entities;
using Hotel_U_W_U.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_U_W_U.Controllers.Main_Pages
{
    public class AccountController : Controller
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel account)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            var user = await _userManager.FindByNameAsync(account.Username);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid Credentials");
                return View();
            }
            var signInResult = await _signInManager.PasswordSignInAsync(user, account.Password, true, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Invalid Credentials");
                return View();
            }
            var userRoles = await _userManager.GetRolesAsync(user);
            if (userRoles.Contains(RoleConstants.Admin))
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel account)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbUser = await _userManager.FindByNameAsync(account.Username);

            if (dbUser != null)
            {
                ModelState.AddModelError(nameof(RegisterViewModel.Username), "username in use");
                return View();
            }

            User newUser = new User
            {
                UserName = account.Username,
                Email = account.Email,

            };

            var identityResult = await _userManager.CreateAsync(newUser, account.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(newUser, RoleConstants.User);
            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");

        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }



    }
}
