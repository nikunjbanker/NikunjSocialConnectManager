using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SanketSocialContactManager.Controllers
{
  public class HomeController : Controller
  {
    [AllowAnonymous]
    public ActionResult Index()
    {
      Trace.WriteLine("Entering Index method");
      ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
      Trace.TraceInformation("Displaying the Index page at " + DateTime.Now.ToLongTimeString());
      Trace.WriteLine("Leaving Index method");
      return View();
    }

    public ActionResult About()
    {
      Trace.WriteLine("Entering About method");
      ViewBag.Message = "Your app description page.";
      Trace.TraceWarning("Transient error on the About page at " + DateTime.Now.ToShortTimeString());
      Trace.WriteLine("Leaving About method");
      return View();
    }

    public ActionResult Contact()
    {
      Trace.WriteLine("Entering Contact method");
      ViewBag.Message = "Your contact page.";
      Trace.TraceError("Fatal error on the Contact page at " + DateTime.Now.ToLongTimeString());
      Trace.WriteLine("Leaving Contact method");
      return View();
    }
  }
}
