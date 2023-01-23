using ecommarceapi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using  Newtonsoft.Json;
using System.Web;
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
        public ActionResult<string> sellersignup(string psignupstring)
        {
            
            Console.WriteLine(psignupstring);
            signupmodel signupobj=JsonConvert.DeserializeObject<signupmodel>(psignupstring);
           string response= sellerlogic.signup(signupobj);

            return response;
        }


    }
}
