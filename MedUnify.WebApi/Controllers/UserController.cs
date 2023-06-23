using MedUnify.WebApi.Data.Entities;
using MedUnify.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MedUnify.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : MedUnifyControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            var resp = await _userService.FindAsync(user);
            if (resp == null)
            {
                return Ok("User not exist.");
            }
            //get token
            return Ok("token");
        }
    }
}
