namespace NikunjSocialContactManager.Migrations
{
  using NikunjSocialConnectManager.Models;
  using NikunjSocialContactManager.Models;
  using System.Data.Entity.Migrations;

  internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(ApplicationDbContext context)
    {
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

