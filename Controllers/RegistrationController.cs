using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Model;
using System.Data.SqlClient;

namespace SocialMedia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public RegistrationController(IConfiguration configuration)
        {
            _configuration = configuration; 
        }

        [HttpPost]
        [Route("Registration")]
        public Response Register(Registration registration)
        {
            Response response = new Response();
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("").ToString());

            return response;
        }
    }
}
