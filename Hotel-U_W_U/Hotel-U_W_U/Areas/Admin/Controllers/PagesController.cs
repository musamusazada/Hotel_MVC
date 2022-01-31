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
    public class PagesController : Controller
    {
        private readonly AppDbContext _context;
        public PagesController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Contact()
        {
            var cp = _context.ContactPages.FirstOrDefault();
            return View(cp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveContact(ContactPage model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Contact));
            }
            var cp = await _context.ContactPages.FirstOrDefaultAsync();

            if (cp == null)
            {
                return NotFound();
            }
            if (!(model.pageFile == null))
            {
                if (!model.pageFile.isSupported("image"))
                {
                    ModelState.AddModelError("File", "File type is unsupported");
                }
                if (!model.pageFile.IsGreaterThanGivenLength(1024))
                {
                    ModelState.AddModelError("File", "File is too large");
                }
                cp.pageImg = FileUtil.CreateFile(FileConstants.imagePath, model.pageFile);
            }
            cp.pageIntro = model.pageIntro;
            cp.pageTitle = model.pageTitle;

            cp.location = model.location;
            cp.phone = model.phone;
            cp.email = model.email;

            cp.UpdatedDate = DateTime.Now;

            _context.Update(cp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Contact));

        }

        public IActionResult Service()
        {
            var sp = _context.ServicePages.FirstOrDefault();
            return View(sp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveService(ServicePage model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Contact));
            }
            var sp = await _context.ServicePages.FirstOrDefaultAsync();

            if (sp == null)
            {
                return NotFound();
            }
            if (!(model.pageFile == null))
            {
                if (!model.pageFile.isSupported("image"))
                {
                    ModelState.AddModelError("File", "File type is unsupported");
                }
                if (!model.pageFile.IsGreaterThanGivenLength(1024))
                {
                    ModelState.AddModelError("File", "File is too large");
                }
                sp.pageImg = FileUtil.CreateFile(FileConstants.imagePath, model.pageFile);
            }
            sp.pageIntro = model.pageIntro;
            sp.pageTitle = model.pageTitle;
            sp.mainText = model.mainText;
            sp.mainTitle = model.mainTitle;



            sp.UpdatedDate = DateTime.Now;

            _context.Update(sp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Contact));

        }
    }
}
