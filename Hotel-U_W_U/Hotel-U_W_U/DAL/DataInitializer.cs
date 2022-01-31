using Hotel_U_W_U.Constants;
using Hotel_U_W_U.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_U_W_U.DAL
{
    public class DataInitializer
    {
        private readonly AppDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;
        public DataInitializer(AppDbContext context, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task seedDATA()
        {
            _context.Database.Migrate();
            if (!_context.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole(RoleConstants.Admin));
                await _roleManager.CreateAsync(new IdentityRole(RoleConstants.Moderator));
                await _roleManager.CreateAsync(new IdentityRole(RoleConstants.Hotel));
                await _roleManager.CreateAsync(new IdentityRole(RoleConstants.User));


            }
            if (!_context.Users.Any())
            {
                User admin = new User
                {
                    UserName = "admin-hotel",
                    Email = "thomas@gmail.com",
                };
                await _userManager.CreateAsync(admin, "AdminAdmin123_");
                await _userManager.AddToRoleAsync(admin, RoleConstants.Admin);
            }
            if (!_context.DefSettings.Any())
            {
                Setting settings = new Setting
                {
                    logoImg = "logo.png",
                    location = "Tokio, Japan",
                    receptionPhone = "+1 (603)535-4592",
                    shuffleServicePhone = "+1(603)535-4592",
                    restaurantPhone = "+1 (603)535-4592"

                };
                await _context.DefSettings.AddAsync(settings);
            }

            if (!_context.ContactPages.Any())
            {
                ContactPage contactPage = new ContactPage
                {
                    pageTitle = "Əlaqə",
                    pageIntro = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Sequi quis molestias voluptas laborum..",
                    pageImg = "contact/bg.jpg",
                    location = "Tokio,Japan",
                    email = "custom@email.com",
                    phone = "+994 51 999333999"
                };
                await _context.ContactPages.AddAsync(contactPage);
            }

            if (!_context.Services.Any())
            {
                List<Service> services = new List<Service>
                {
                    new Service{
                    name = "Lounge Bar",
                    description = "Top Lounge Bar service",
                    img = "services/1.jpg",

                    },
                    new Service
                    {
                    name = "Hovuz",
                    description = "Isti Soyuq Hovuz",
                    img = "services/2.jpg"
                    },
                    new Service
                    {
                    name = "Restorant",
                    description = "Best food and drinks ",
                    img = "services/3.jpg"
                    },
                    new Service
                    {
                    name = "Oyun Zali",
                    description = "Drink Vodka , Play Dotka",
                    img = "services/4.jpg"
                    },
                    new Service
                    {
                    name = "Spa Salonu",
                    description = "Rest like queens or kings",
                    img = "services/5.jpg"
                    },
                    new Service
                    {

                    name = "Idman Zali",
                    description = "Train Like King-Kong",
                    img = "services/6.jpg"
                    }
                };

                foreach (var item in services)
                {
                    _context.Services.Add(item);
                }
            }
            _context.SaveChanges();

            if (!_context.ServicePages.Any())
            {
                ServicePage sp = new ServicePage
                {
                    pageImg = "services/bg.jpeg",
                    pageTitle = "Xidmetlerimiz",
                    pageIntro = "Xidmetlerimiz gozeldir",
                    mainTitle = "Butun Xidmetlerimiz",
                    mainText = "Butun gozel xidmetlerimiz",
                    Services = _context.Services.ToList(),
                };
                await _context.ServicePages.AddAsync(sp);
            }



            _context.SaveChanges();
        }
    }
}
