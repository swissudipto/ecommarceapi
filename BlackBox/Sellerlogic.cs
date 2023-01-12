using ecommarceapi.Interfaces;
using ecommarceapi;
using ecommarceapi.Models;

public class sellerlogic : ISellerlogic
{
    public readonly MasterContext context;
    public sellerlogic()
    {
        context = new MasterContext();
    }
    public string signup(signupmodel signupobj)
    {
      var Userobj=context.UserCreds.Where(x=> x.Username==signupobj.Username);
      if(Userobj!=null)
      {
        /*if(Userobj.Password==signupobj.password)
        {
        return "Success";
        }
        else
        {
          return "Wrong password";
        }*/
      }

        return "User Name is Incorrect";
    }
}