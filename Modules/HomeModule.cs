using Nancy;
using JobBoard.Objects;
using System.Collections.Generic;

namespace JobBoard
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["home.cshtml"];

      Get["/add_job"] = _ => View["add_job.cshtml"];

      Post["/post_job"] = _ => {
        JobOpening newJobOpening = new JobOpening (
          Request.Form["title"],
          Request.Form["description"],
          Request.Form["name"],
          Request.Form["phone"],
          Request.Form["email"]
        );
        return View["view_job.cshtml",newJobOpening];
      };
    }
  }
}
