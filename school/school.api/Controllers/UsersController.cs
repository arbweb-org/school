using Microsoft.AspNetCore.Mvc;

namespace school.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("get_users")]
        public string get_users() 
        {
            return "user";
        }
    }
}