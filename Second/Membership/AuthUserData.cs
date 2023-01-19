namespace Membership;
using CRM;
using System.Collections.Generic;

public class AuthUserData{
    public static List<User> users = new List<User>(); 
    
    public bool Add(string fname, string lname,string email, string pass){
        foreach(User user in users){
            if(user.Email.Equals(email)){
                return false;
            }
        }
        users.Add(new User(fname,lname,email,pass));
        return true;
    }

    public bool VerifyUser(string email,string pass){
        bool res = false;

        foreach(User user in users){
            if(user.Email.Equals(email) && user.Password.Equals(pass)){
                res =  true;
            }
        }
        return res;

    }

    public bool ChangePassword(string email,string oldpass, string newpass){
        foreach(User user in users){
            if(user.Email.Equals(email) && user.Password.Equals(oldpass)){
                user.Password = newpass;
                return true;
            }
        }
        return false;
    }

}