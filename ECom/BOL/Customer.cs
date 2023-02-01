namespace BOL;

public class Customer{
    public int Id {get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Email{get;set;}
    public string Password{get;set;}
    public string ContactNumber{get;set;}
    public int RoleId {get;set;}

    public Customer(string firstName, string lastName, string email, string password, string contactNumber)
    {
        Id = (new Random()).Next();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        ContactNumber = contactNumber;
    }
    public Customer(){

    }

    public override string ToString()
    {
        return Email+"--"+Password;
    }
}