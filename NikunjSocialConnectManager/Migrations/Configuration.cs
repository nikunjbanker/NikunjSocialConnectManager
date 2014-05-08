namespace NikunjSocialContactManager.Migrations
{
  using NikunjSocialConnectManager.Models;
  using NikunjSocialContactManager.Models;
  using System.Data.Entity.Migrations;
  using Microsoft.AspNet.Identity;
  using Microsoft.AspNet.Identity.EntityFramework;


  internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
    }

    bool AddUserAndRole(ApplicationDbContext context)
    {
      IdentityResult ir;
      var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
      ir = rm.Create(new IdentityRole("canEdit"));
      var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
      var user = new ApplicationUser()
      {
        UserName = "nikunjbanker",
      };
      ir = um.Create(user, "nikunj.1982");
      if (ir.Succeeded == false)
      {
        return ir.Succeeded;
      }
      ir = um.AddToRole(user.Id, "canEdit");
      return ir.Succeeded;
    }


    protected override void Seed(ApplicationDbContext context)
    {
      AddUserAndRole(context);

      context.Contacts.AddOrUpdate(p => p.Name,
          new Contact
          {
            Name = "Sanket Shah",
            Address = "E-41, Yash Towers, 100 ft. Road, Satellite",
            City = "Ahmedabad",
            State = "Gujarat",
            Zip = "380051",
            Email = "sanket.shah@outlook.com",
          },
          new Contact
          {
            Name = "Umang Thakkar",
            Address = "A-16, Blueline Avenue, Kandivali East",
            City = "Mumbai",
            State = "Maharashtra",
            Zip = "400065",
            Email = "umang.thakkar@example.com",
          }
          );
    }
  }
}

