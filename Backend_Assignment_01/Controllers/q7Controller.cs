    using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Assignment_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        /// <summary>
        /// Returns a string representation of the current date (formatted yyyy-MM-dd), adjusted by {days}
        /// </summary>
        /// <param name="days">The number of days that needs to be added to today</param>
        /// <returns>
        /// Returns the date after adding the input number to today's date
        /// </returns>
        /// <example>
        /// GET api/q7/timemachine?days=1
        /// </example>
        /// /// <example>
        /// GET api/q7/timemachine?days=-1
        /// </example>
        /// /// <example>
        /// GET api/q7/timemachine?days=4
        /// </example>
        [HttpGet(template: "timemachine")]
        public string TimeMachine(int days)
        {
            DateTime calcDate = DateTime.Today;
            DateTime answer = calcDate.AddDays(days);
            return answer.ToString("yyyy-MM-dd");
        }
    }
}
