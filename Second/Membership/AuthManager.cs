namespace Membership;
public static class AuthManager
{
    private static AuthUserData authdata = new AuthUserData(); 

    public static bool Validate(string email,string pass){
        return authdata.VerifyUser(email,pass);
    }

    public static bool Register( string fname, string lname,string email, string pass){
        return authdata.Add(fname,lname,email,pass);
    }

    public static bool ChangePassword(string email,string oldpass, string newpass){
        return authdata.ChangePassword(email,oldpass,newpass);
    }

}
