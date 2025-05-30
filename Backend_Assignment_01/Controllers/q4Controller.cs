using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Assignment_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        /// <summary>
        /// Returns the start of a Knock Knock joke
        /// </summary>
        /// <returns>
        /// The output would be the next part of the joke - "Who's there?"
        /// </returns>
        /// <example>
        /// POST api/q4/knockknock
        /// </example>
        [HttpPost(template: "knockknock")]
        public string KnockKnock()
        {
            return "Who's there?";
        }
    }
}
