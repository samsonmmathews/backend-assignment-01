using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Assignment_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Quest01Controller : ControllerBase
    {
        /// <summary>
        /// Welcomes the user
        /// </summary>
        /// <returns>
        /// A welcome message
        /// </returns>
        /// <example>
        /// GET: api/Quest01/Welcome -> "Welcome to 5125!"
        /// </example>

        [HttpGet(template: "Welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
