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
        newJobOpening.Save();
        return View["view_job.cshtml",newJobOpening];
      };
      Get["/view_all"] = _ => {
        List<JobOpening> allJobs = JobOpening.GetJobs();
        return View["job_board.cshtml", allJobs];
      };

      Get["/search_form"] = _ => View["search_form.cshtml"];

      Post["/search_jobs"] = _ => {
        List<JobOpening> searchedJobs = JobOpening.SearchJobs(Request.Form["search-keyword"]);
        return View["job_board.cshtml",searchedJobs];
      };
    }
  }
}
