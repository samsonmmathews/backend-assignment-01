using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Assignment_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// Returns the area of a regular hexagon with side length double {S} using the formula given
        /// </summary>
        /// <param name="side">The length of one side of a hexagon</param>
        /// <returns>
        /// Returns the area of the hexagon
        /// </returns>
        /// <example>
        /// GET api/q6/hexagon?side=1
        /// </example>
        /// /// <example>
        /// GET api/q6/hexagon?side=1.5
        /// </example>
        /// /// <example>
        /// GET api/q6/hexagon?side=20
        /// </example>
        [HttpGet(template: "hexagon")]
        public double Area(double side)
        {
            return ((3 * (Math.Sqrt(3) / 2)) * (Math.Pow(side, 2)));
        }
    }
}
