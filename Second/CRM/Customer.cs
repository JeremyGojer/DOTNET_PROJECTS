namespace CRM;
using OrderProcessing;
using System.Collections.Generic;
public class Customer
{
    public int CustomerId {get;set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string Email {get;set;}
    public string PhoneNo {get;set;}
    public List<string> Locations {get;set;}
    public List<Order> Orders {get;set;} 

    public Customer(){
        CustomerId = 0;
        FirstName = "John";
        LastName = "Doe";
        Email = "John.Doe@unknown.com";
        PhoneNo = "0123456789";
        Locations = new List<string>();
        Orders = new List<Order>();
    }

    public Customer(int customerId, string firstName, string lastName, string email, string phoneNo, List<string> location, List<Order> orders)
    {
        CustomerId = customerId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNo = phoneNo;
        Locations = location;
        Orders = orders;
    }
    

    public string OrdersToString(){
        string res = "";
        foreach (Order order in Orders){
            res = "\n" + res + order ; 
        }
        return res;
    }
    public string LocationsToString(){
        string res = "";
        foreach (string loc in Locations){
            res = "\n" + res + loc; 
        }
        return res;
    }

    public override string ToString()
    {
        return base.ToString() + "\nId : " + this.CustomerId
                                + "\nFirstName : " + this.FirstName
                                + "\nLastName : " + this.LastName
                                + "\nEmail : " + this.Email
                                + "\n***Locations***" + this.LocationsToString()
                                + "\nPhoneNo : " + this.PhoneNo
                                + "\n***Orders***" + this.OrdersToString();
    }
}
