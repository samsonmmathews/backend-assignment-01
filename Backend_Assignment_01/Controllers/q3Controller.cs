using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Assignment_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        /// <summary>
        /// Displays the cube of an integer
        /// </summary>
        /// <param name="number">The input number for which the cube needs to be found</param>
        /// <returns>
        /// Returns the cube of the integer
        /// </returns>
        /// <example>
        /// GET api/q3/cube?number=4
        /// </example>
        /// <example>
        /// GET api/q3/cube?number=-4
        /// </example>
        /// /// <example>
        /// GET api/q3/cube?number=10
        /// </example>
        [HttpGet(template: "cube/{number}")]
        public int Cube(int number)
        {
            return (number * number * number);
        }
    }
}
