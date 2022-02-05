using Hotel_U_W_U.DAL;
using Hotel_U_W_U.Models.Entities;
using Hotel_U_W_U.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_U_W_U.Controllers
{
    public class RoomController : Controller
    {
        private readonly AppDbContext _context;

        public RoomController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var rooms = await _context.rooms.Where(room => room.isDeleted == false).ToListAsync();
            return View(rooms);
        }


        public async Task<IActionResult> RoomPage(int id)
        {

            var _room = await _context.rooms.Include(c => c.sideImages).FirstOrDefaultAsync(r => r.id == id);
            var roomViewModel = new RoomViewModel
            {
                room = _room
            };
            return View(roomViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reserve(RoomViewModel roomVM, int id)
        {
            var reservations = await _context.Reservations.Where(r => r.roomID == id).ToListAsync();
            DateTime checkIn = roomVM.reservation.checkIn;
            DateTime checkOut = roomVM.reservation.checkOut;
            List<bool> availability = new List<bool>();
            if (reservations.Count == 0)
            {
                var newReservation = new Reservation
                {
                    checkIn = roomVM.reservation.checkIn,
                    checkOut = roomVM.reservation.checkOut,
                    roomID = id,

                };
                await _context.Reservations.AddAsync(newReservation);
                await _context.SaveChangesAsync();
                TempData["reservation"] = "Success";
                return RedirectToAction("RoomPage", new { id = id });
            }
            else
            {
                foreach (var item in reservations)
                {
                    int checkInResult = DateTime.Compare(checkIn, item.checkIn);
                    int checkOutResult = DateTime.Compare(checkOut, item.checkOut);

                    if ((checkInResult < 0 && checkOutResult < 0) || (checkInResult > 0 && checkOutResult > 0))
                    {
                        availability.Add(true);
                    }
                    else if (checkInResult == 0 || checkOutResult == 0)
                    {
                        availability.Add(false);

                    }
                    else
                    {
                        availability.Add(false);

                    }
                }
            }

            if (!availability.Contains(false))
            {
                var newReservation = new Reservation
                {
                    checkIn = roomVM.reservation.checkIn,
                    checkOut = roomVM.reservation.checkOut,
                    roomID = id,

                };
                await _context.Reservations.AddAsync(newReservation);
                await _context.SaveChangesAsync();
                TempData["reservation"] = "Success";
                return RedirectToAction("RoomPage", new { id = id });
            }

            ViewData["reservation"] = "Please pick a valid date";
            return RedirectToAction("RoomPage", new { id = id });
        }
    }
}
