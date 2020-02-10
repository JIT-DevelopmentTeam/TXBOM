using Microsoft.AspNetCore.Antiforgery;
using JIT_TXBOM.Controllers;

namespace JIT_TXBOM.Web.Host.Controllers
{
    public class AntiForgeryController : JIT_TXBOMControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
