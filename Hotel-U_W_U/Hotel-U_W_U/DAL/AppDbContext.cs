using Hotel_U_W_U.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hotel_U_W_U.DAL
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Setting> DefSettings { get; set; }
        public DbSet<ContactPage> ContactPages { get; set; }
        public DbSet<ServicePage> ServicePages { get; set; }

        public DbSet<Service> Services { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Comment> commnets { get; set; }
        public DbSet<RoomImage> roomImages { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}
