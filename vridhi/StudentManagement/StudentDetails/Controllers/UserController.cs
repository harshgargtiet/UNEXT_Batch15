using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDetails.Models;
using StudentDetails.Services.Interface;

namespace StudentDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
      

        private IUser _user;

        private IToken _tokenGenerator;



        public UserController(IUser user, IToken tokenGenerator)

        {

            _user = user;

            _tokenGenerator = tokenGenerator;

        }



        [HttpGet]

        public async Task<ActionResult<string>> GetUserByUsername(string username)

        {

            try

            {

                var user = await _user.GetUserByUsername(username);

                var token = _tokenGenerator.GenerateToken(user.UserName, user.Role);

                return Ok(token);

            }

            catch (Exception ex)

            {

                return NotFound(ex.Message);

            }

        }



        [HttpPost]

        public async Task<ActionResult<List<User>>> AddUser(User user)

        {

            return Ok(await _user.AddUser(user));

        }
    }
}
