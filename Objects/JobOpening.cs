using System.Collections.Generic;

namespace JobBoard.Objects
{
  public class JobOpening {
    private string _title;
    private string _description;
    private ContactInfo _contactInfo;
    private static List<JobOpening> _jobOpenings = new List<JobOpening> {};

    public JobOpening (string title, string description, string name, string phoneNumber, string email) {
      _title = title;
      _description = description;
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
    public void Save()
    {
      _jobOpenings.Add(this);
    }
    public static List<JobOpening> GetJobs()
    {
      return _jobOpenings;
    }
  }
}
