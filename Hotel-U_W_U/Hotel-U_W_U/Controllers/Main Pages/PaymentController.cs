using Hotel_U_W_U.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Stripe;
using System;

namespace Hotel_U_W_U.Controllers.Main_Pages
{
    public class PaymentController : Controller
    {
        public IActionResult Index(int total)
        {
            TempData["totalPrice"] = total;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<dynamic> Pay(Payment pm, int total)
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_51KQ68fCHInBeireDJwOUoPslOtJrr3TajP6uJdgCAEoYd2RKtgumuG9OQkD5Rh8IQyaJuZf2aiFzoJZzD47Fasxv00bqwgRGfC";

                var optionstoken = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = pm.cardNumber,
                        ExpMonth = pm.month,
                        ExpYear = pm.year,
                        Cvc = pm.cvc,
                        Name = pm.fullName,
                    },
                };
                var serviceToken = new TokenService();
                Token stripeToken = await serviceToken.CreateAsync(optionstoken);

                var options = new ChargeCreateOptions
                {
                    Amount = Convert.ToInt64(total) + 5,
                    Currency = "pln",
                    Description = "test",
                    Source = stripeToken.Id
                };

                var service = new ChargeService();
                Charge charge = await service.CreateAsync(options);

                if (charge.Paid)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception e)
            {

                return RedirectToAction("Index", "Home");
            }
        }
    }
}
