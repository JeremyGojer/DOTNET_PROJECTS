namespace SAL;
using System.Collections.Generic;
using BOL;

public class UserServices{
    private static List<User> userList = new List<User>();
    
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
        // Console.WriteLine("Added New User");
        userList.Add(new User(firstName,lastName,email,password,contactNumber));
        
        // foreach(var user in userList){
        //     Console.WriteLine(user);
        // }
        return true;
    }

    public List<User> DisplayAllUsers(){
        return userList;
    }
}