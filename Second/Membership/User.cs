namespace Membership;

public class User{
    public int UserId {get;set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string Email {get;set;}
    public string Password{get;set;}
    private static int userIdGen = 0;

    public User()
    {
        UserId = 0;
        FirstName = "John";
        LastName = "Doe";
        Email = "John.Doe@unknown.com";
        Password = "unknown";
    }

    public User(string firstName, string lastName, string email, string password)
    {
        UserId = userIdGen++;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        //Add this data to CRM too
    }

    public override string ToString()
    {
        return base.ToString() + "\n" + this.UserId
                                + "\n" + this.FirstName
                                + "\n" + this.LastName
                                + "\n" + this.Email
                                + "\n" + this.Password;
    }
}