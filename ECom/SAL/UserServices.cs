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
    
    public string Authenticate(string email,string password){
        foreach(var user in userList){
            if(user.Email == email && user.Password == password)
            {
                return user.Id+"";
            }
        }
        return "";
    }

    public bool Register(string firstName,string lastName,string email,string password,string contactNumber, int roleid){
        foreach(var user in userList){
            if(user.Email == email){
                return false;
            }
        }
        Customer customer = new Customer(firstName,lastName,email,password,contactNumber);
        customer.RoleId = roleid;
        customerManager.AddCustomer(customer);
        Console.WriteLine("Added New User");
        //userList.Add(new Customer(firstName,lastName,email,password,contactNumber));
        
        return true;
    }

    public List<Customer> DisplayAllUsers(){
        return userList;
    }

    public Customer FindUserById(int id){
        foreach(var user in userList){
            if(user.Id == id){
                return user;
            }
        }
        return null;
    }

    
}