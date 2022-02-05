using Hotel_U_W_U.Constants;
using Hotel_U_W_U.DAL;
using Hotel_U_W_U.Models.Entities;
using Hotel_U_W_U.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_U_W_U.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin,mod,hotel")]
    public class HotelController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public HotelController(AppDbContext context, UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user.hasHotel)
            {
                var hotel = await _context.hotels.FirstOrDefaultAsync(h => h.userID == user.Id);
                var rooms = await _context.rooms.Where(r => r.isDeleted == false).Include(c => c.hotel).Include(room => room.sideImages).ToListAsync();
                ViewData["rooms"] = rooms;
                return View(hotel);
            }

            return RedirectToAction(nameof(CreateHotel));
        }
        public async Task<IActionResult> CreateHotel()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user.hasHotel)
            {
                return RedirectToAction(nameof(Index));

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateHotel(Hotel model)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);



            model.img = FileUtil.CreateFile(FileConstants.imagePath, model.file);

            Hotel hotel = new Hotel
            {
                name = model.name,
                desc = model.desc,
                img = model.img,
                userID = user.Id,
                user = model.user,
            };

            await _context.hotels.AddAsync(hotel);
            user.hasHotel = true;
            user.hasHotel = true;
            _context.Update(user);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CreateRoom(int id)
        {
            var hotel = await _context.hotels.FirstOrDefaultAsync(item => item.id == id);
            if (hotel == null)
            {
                return NotFound();
            }
            ViewData["hotel"] = hotel.id;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRoom(Room room, int id)
        {

            var hotel = await _context.hotels.FirstOrDefaultAsync(item => item.id == id);
            if (hotel == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Invalid Fields");
                return View();
            }

            if (!(room.mainFile == null))
            {
                if (!room.mainFile.isSupported("image"))
                {
                    ModelState.AddModelError("mainFile", "File type is unsupported");

                }
                if (!room.mainFile.IsGreaterThanGivenLength(1024))
                {
                    ModelState.AddModelError("mainFile", "File is too large");


                }
                room.mainImg = FileUtil.CreateFile(FileConstants.imagePath, room.mainFile);
            }
            var newRoom = new Room
            {
                hotelID = hotel.id,
                hotel = hotel,
                roomType = room.roomType,
                roomDesc = room.roomDesc,
                roomTitle = room.roomTitle,
                roomSqr = room.roomSqr,
                adultCount = room.adultCount,
                kidCount = room.kidCount,
                mainImg = room.mainImg,
                pricePerNight = room.pricePerNight,

            };
            if (!(room.sideFiles == null))
            {
                foreach (var item in room.sideFiles)
                {

                    if (!item.isSupported("image"))
                    {
                        ModelState.AddModelError("sideFile", "File type is unsupported");
                    }
                    if (!item.IsGreaterThanGivenLength(1024))
                    {
                        ModelState.AddModelError("sideFile", "File is too large");
                    }
                    var roomIMAGE = new RoomImage
                    {
                        room = newRoom,
                        roomID = newRoom.id,

                    };
                    roomIMAGE.img = FileUtil.CreateFile(FileConstants.imagePath, item);

                    await _context.roomImages.AddAsync(roomIMAGE);
                }

            }
            else
            {
                ModelState.AddModelError("File", "Please enter Side Images");
            }


            await _context.rooms.AddAsync(newRoom);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Hotel");
        }


        public async Task<IActionResult> DeleteRoom(int id)
        {

            var room = await _context.rooms.FirstOrDefaultAsync(room => room.id == id);
            room.isDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

    }
}
