using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Assignment_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        /// <summary>
        /// Returns an acknowledgement of the {secret} integer
        /// </summary>
        /// <param name="secret">The secret number taken from the user</param>
        /// <returns>
        /// Returns the number input by the user along with the text
        /// </returns>
        /// <example>
        /// "POST" -d "5" -H "Content-Type: application/json" "...api/q5/secret"
        /// </example>
        [HttpPost(template:"secret")]
        public string Secret([FromBody] int secret)
        {
            return $"Shh.. the secret is {secret}";
        }
    }
}
