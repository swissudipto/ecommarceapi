using ecommarceapi.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace ecommarceapi.Controllers{
    [ApiController]
    [Route("Seller")]
    public class SellerController: ControllerBase
    {
        public readonly ISellerlogic sellerlogic;

        public SellerController(ISellerlogic _sellerlogic)
        {
            sellerlogic=_sellerlogic;
        }
        [HttpPost]
        public string sellersignup(signupmodel signupobj)
        {
           string response= sellerlogic.signup(signupobj);

            return response;
        }


    }
}