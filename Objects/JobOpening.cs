using System.Collections.Generic;

namespace JobBoard.Objects
{
  public class JobOpening {
    private string _title;
    private string _description;
    private int _salary;
    private ContactInfo _contactInfo;
    private static List<JobOpening> _jobOpenings = new List<JobOpening> {};

    public JobOpening (string title, string description, int salary, string name, string phoneNumber, string email) {
      _title = title;
      _description = description;
      _salary = salary;
      _contactInfo = new ContactInfo (name, phoneNumber, email);
    }

    public string GetTitle()
    {
      return _title;
    }

    public string GetDescription()
    {
      return _description;
    }

    public ContactInfo GetContact() {
      return _contactInfo;
    }

    public int GetSalary() {
      return _salary;
    }

    public void Save()
    {
      _jobOpenings.Add(this);
    }

    public static List<JobOpening> GetJobs()
    {
      return _jobOpenings;
    }

    public static List<JobOpening> SearchJobs(string searchTerm, int minSalary)
    {
      List<JobOpening> searchedList = new List<JobOpening> {};
      foreach(JobOpening job in _jobOpenings)
      {
        if ((job._title.ToLower().Contains(searchTerm.ToLower()) || job._description.ToLower().Contains(searchTerm.ToLower()))&&(job._salary >= minSalary))
        {
          searchedList.Add(job);
        }
      }
      return searchedList;
    }

  }
}
