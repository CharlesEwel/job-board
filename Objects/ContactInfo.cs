using System.Collections.Generic;

namespace JobBoard.Objects
{
  public class ContactInfo {
    private string _name;
    private string _phoneNumber;
    private string _email;

    public ContactInfo(string name, string phoneNumber, string email)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _email = email;
    }

    public string GetName()
    {
      return _name;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public string GetEmail()
    {
      return _email;
    }
  }
}
