using Hotel_U_W_U.Areas.Admin.ViewModels;
using Hotel_U_W_U.Constants;
using Hotel_U_W_U.DAL;
using Hotel_U_W_U.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_U_W_U.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin,mod")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(AppDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _context.Users.ToListAsync();
            var userList = new List<UserViewModel>();

            foreach (var u in users)
            {
                userList.Add(new UserViewModel
                {
                    id = u.Id,
                    username = u.UserName,
                    email = u.Email,
                    Role = (await _userManager.GetRolesAsync(u))[0],
                });
            }
            return View(userList);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MakeAdmin(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            if ((await _userManager.GetRolesAsync(user)).Contains(RoleConstants.Admin))
            {
                return RedirectToAction("Index", "Account");

            }
            await _userManager.AddToRoleAsync(user, RoleConstants.Admin);


            return RedirectToAction("Index", "Account");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MakeHotel(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            if ((await _userManager.GetRolesAsync(user)).Contains(RoleConstants.Hotel))
            {
                return RedirectToAction("Index", "Account");

            }
            user.hasHotel = true;
            await _userManager.RemoveFromRoleAsync(user, RoleConstants.User);
            await _userManager.AddToRoleAsync(user, RoleConstants.Hotel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Account");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ban(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            await _userManager.SetLockoutEnabledAsync(user, true);
            await _userManager.SetLockoutEndDateAsync(user, DateTime.Today.AddYears(20));

            return RedirectToAction("Index", "Account");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Unlock(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            await _userManager.SetLockoutEnabledAsync(user, false);
            await _userManager.SetLockoutEndDateAsync(user, DateTime.Parse("01/01/1000"));


            return RedirectToAction("Index", "Account");

        }
    }
}
