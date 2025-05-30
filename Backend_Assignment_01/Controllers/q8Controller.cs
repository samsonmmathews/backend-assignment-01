using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Globalization;

namespace Backend_Assignment_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        /// <summary>
        /// An online store checkout simulator
        /// </summary>
        /// <param name="Small">The quantity of small plushies</param>
        /// <param name="Large">The quantity of large plushies</param>
        /// <returns>
        /// Returns the total amount of the order after calculating the total amount from the number of small and large plushies and then by adding the tax to that amount
        /// </returns>
        /// <example>
        /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "Small=1&Large=1" ".../api/q8/squashfellows"
        /// </example>
        /// /// <example>
        /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "Small=2&Large=1" ".../api/q8/squashfellows"
        /// </example>/// <example>
        /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "Small=100&Large=100" ".../api/q8/squashfellows"
        /// </example>
        [HttpPost(template: "squashfellows")]
        public string CheckoutTotal([FromForm] int Small, [FromForm] int Large)
        {
            double totalSmall = Small * 25.50;
            double totalLarge = Large * 40.50;
            double subTotal = totalSmall + totalLarge;
            double totalTax = Math.Round((subTotal * 0.13), 2);
            double total = subTotal + totalTax;
            return $"{Small} Small @ $25.50 = ${totalSmall.ToString("F",CultureInfo.InvariantCulture)}; {Large} Large @ $40.50 = ${totalLarge.ToString("F", CultureInfo.InvariantCulture)}; Subtotal = ${subTotal.ToString("F", CultureInfo.InvariantCulture)}; Tax = ${totalTax.ToString("F", CultureInfo.InvariantCulture)} HST; Total = ${total.ToString("F", CultureInfo.InvariantCulture)}";
        }
    }
}
