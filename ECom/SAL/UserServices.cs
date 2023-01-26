namespace SAL;
using System.Collections.Generic;
using BOL;
using BLL;

public class UserServices{
    private CustomerManager customerManager = CustomerManager.GetCustomerManager();
    private List<Customer> userList;
    public UserServices(){
        userList = customerManager.GetAll();
    }
    
    public bool Authenticate(string email,string password){
        foreach(var user in userList){
            if(user.Email == email && user.Password == password)
            {
                return true;
            }
        }
        return false;
    }

    public bool Register(string firstName,string lastName,string email,string password,string contactNumber){
        foreach(var user in userList){
            if(user.Email == email){
                return false;
            }
        }
        customerManager.AddCustomer(new Customer(firstName,lastName,email,password,contactNumber));
        Console.WriteLine("Added New User");
        //userList.Add(new Customer(firstName,lastName,email,password,contactNumber));
        
        return true;
    }

    public List<Customer> DisplayAllUsers(){
        return userList;
    }
}