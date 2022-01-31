using Hotel_U_W_U.Constants;
using Hotel_U_W_U.DAL;
using Hotel_U_W_U.Models.Entities;
using Hotel_U_W_U.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_U_W_U.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin,mod")]
    public class ServiceCRUDController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceCRUDController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var services = await _context.Services.ToListAsync();
            return View(services);
        }


        public async Task<IActionResult> Edit(int id)
        {

            var model = await _context.Services.FindAsync(id);

            if (model == null)
            {
                return NotFound();
            }
            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Service model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            var service = await _context.Services.FirstOrDefaultAsync(item => item.id == model.id && item.isDeleted == false);

            if (service == null)
            {
                return NotFound();
            }
            if (!(model.file == null))
            {
                if (!model.file.isSupported("image"))
                {
                    ModelState.AddModelError("File", "File type is unsupported");
                }
                if (!model.file.IsGreaterThanGivenLength(1024))
                {
                    ModelState.AddModelError("File", "File is too large");
                }
                service.img = FileUtil.CreateFile(FileConstants.imagePath, model.file);
            }
            service.name = model.name;
            service.description = model.description;
            service.UpdatedDate = DateTime.Now;
            _context.Update(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Service model)
        {
            var service = await _context.Services.FirstOrDefaultAsync(item => item.id == model.id);
            service.isDeleted = true;
            service.DeletedDate = DateTime.Now;

            _context.Update(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
