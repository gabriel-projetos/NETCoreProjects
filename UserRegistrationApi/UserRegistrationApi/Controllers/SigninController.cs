using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace UserRegistrationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SigninController : ControllerBase
    {
        public IConfiguration Configuration { get; }

        public SigninController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpPost(Name = "v1/signin")]
        public async Task<IActionResult> Signin([FromBody] SigninUser login)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Configuration["Jwt:SecretKey"]);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Issuer = "https://userprojets.gabriel.com",
                Audience = "DefaultAudience",
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new
            {
                Token = tokenHandler.WriteToken(token)
            });
        }
    }
}
