using Hotel_U_W_U.Constants;
using Hotel_U_W_U.DAL;
using Hotel_U_W_U.Models.Entities;
using Hotel_U_W_U.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_U_W_U.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin,mod")]
    public class GlobalSettingsController : Controller
    {
        private readonly AppDbContext _context;
        public GlobalSettingsController(AppDbContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            var setting = _context.DefSettings.FirstOrDefault();

            return View(setting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Setting model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            var setting = await _context.DefSettings.FirstOrDefaultAsync();

            if (setting == null)
            {
                return NotFound();
            }
            if(!(model.logoFile == null))
            {
                if (!model.logoFile.isSupported("image")) {
                    ModelState.AddModelError("File", "File type is unsupported");
                }
                if (!model.logoFile.IsGreaterThanGivenLength(1024))
                {
                    ModelState.AddModelError("File", "File is too large");
                }
                setting.logoImg = FileUtil.CreateFile(FileConstants.imagePath, model.logoFile);
            }
            setting.location = model.location;
            setting.restaurantPhone = model.restaurantPhone;
            setting.receptionPhone = model.receptionPhone;
            setting.shuffleServicePhone = model.shuffleServicePhone;
            setting.UpdatedDate = DateTime.Now;

            _context.Update(setting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
