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
      //var Userobj=context.UserCreds.Where(x=> x.Username==signupobj.Username);
      try{
      var maxuserid=context.Usercreds.DefaultIfEmpty().Max(r => r == null ? 0 : r.Userid);

      Usercred newuser=new Usercred(){
          Userid=maxuserid+1,
          Username=signupobj.Username,
          Email=signupobj.email,
          Password=signupobj.password
      };

      context.Usercreds.Add(newuser);
      context.SaveChanges();
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message);
        return "Something went Wrong"+ex.Message;
      }
          
        return "User is created";
    }
}
