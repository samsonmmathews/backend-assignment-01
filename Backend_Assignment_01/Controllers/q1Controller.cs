using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Assignment_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        /// <summary>
        /// Welcomes the user
        /// </summary>
        /// <returns>
        /// A welcome message
        /// </returns>
        /// <example>
        /// GET: api/q1/welcome -> "Welcome to 5125!"
        /// </example>

        [HttpGet(template: "welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
