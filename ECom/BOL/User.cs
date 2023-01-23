namespace BOL;

public class User{
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Email{get;set;}
    public string Password{get;set;}
    public string ContactNumber{get;set;}

    public User(string firstName, string lastName, string email, string password, string contactNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        ContactNumber = contactNumber;
    }
    public override string ToString()
    {
        return Email+"--"+Password;
    }
}