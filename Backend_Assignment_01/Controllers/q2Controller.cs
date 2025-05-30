using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Assignment_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// Greets the user by name
        /// </summary>
        /// <param name="name">The name of the user</param>
        /// <returns>
        /// Returns a greeting message with the inputted name
        /// </returns>
        /// <example>
        /// GET api/q1/greeting?name=Gary
        /// </example>
        /// <example>
        /// GET api/q2/greeting?name=Ren%C3%A9e
        /// </example>
        [HttpGet(template: "greeting")]
        public string Greeting(string name)
        {
            return $"Hi {name}!";
        }
    }
}
