using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;

namespace GoogleAuth.Controllers
{
    [AllowAnonymous, Route("account")]
    public class AccountController : Controller
    {
       // public object CookiesAuthenticaionDefaults { get; private set; }

        [Route("google-login")]
        public IActionResult GoogleLogin()
        {
            var pro = new AuthenticationProperties { RedirectUri = Url.Action("GoogleResponse") };
            return Challenge(pro,GoogleDefaults.AuthenticationScheme);   
        }

        [Route("google-response")]
        public async Task<IActionResult> GoogleResponse()
        {
            var res = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            var claims = res.Principal.Identities.FirstOrDefault()
                .Claims.Select(claim => new
                {
                    claim.Issuer,
                    claim.OriginalIssuer,
                    claim.Type,
                    claim.Value
                });
            return Json(claims);
        }

    }
}
