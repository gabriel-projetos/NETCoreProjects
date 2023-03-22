using Microsoft.AspNetCore.Mvc;

namespace UserRegistrationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SigninController : ControllerBase
    {
        [HttpPost(Name = "v1/signin")]
        public async Task<IActionResult> Signin()
        {
            return new OkResult();
        }
    }
}
