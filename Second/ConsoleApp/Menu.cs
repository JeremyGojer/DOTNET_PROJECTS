using Catalog;
using CRM;
using Membership;
using OrderProcessing;
using System.Collections.Generic;

public class Menu{
    private int choice;
    public void menu(){
        do{
            Console.WriteLine("Enter Choice"+
                                "\n1.Login"+
                                "\n2.Signup"+
                                "\n3.Change Password"+
                                "\n0.Exit");
            choice = Int32.Parse(Console.ReadLine());
            switch(choice){

                case 1: Console.WriteLine("Enter email");
                        string email = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        string pass = Console.ReadLine();
                        if(AuthManager.Validate(email,pass)){
                            Console.WriteLine("WELCOME");
                        }
                        else{
                            Console.WriteLine("DETAILS INCORRECT. PLEASE REENTER YOUR DETIALS");
                        }
                        break;

                case 2: Console.WriteLine("Enter your First Name");
                        string fname = Console.ReadLine();
                        Console.WriteLine("Enter your Last Name");
                        string lname = Console.ReadLine();
                        Console.WriteLine("Enter your Email");
                        email = Console.ReadLine();
                        Console.WriteLine("Enter your Password");
                        pass = Console.ReadLine();
                        if(AuthManager.Register(fname,lname,email,pass)){
                            Console.WriteLine("New User added for "+fname);    
                        }
                        else{
                            Console.WriteLine("This email "+email+" is already registered with us");
                        }
                        break;

                case 3: Console.WriteLine("Enter your registered email");
                        email = Console.ReadLine();
                        Console.WriteLine("Enter your old password");
                        string oldpass = Console.ReadLine();
                        Console.WriteLine("Enter your new password");
                        string newpass = Console.ReadLine();
                        if(AuthManager.ChangePassword(email,oldpass,newpass)){
                            Console.WriteLine("Password changed");
                        }
                        else{
                            Console.WriteLine("Try Again");
                        }
                        break;
                case 0: Console.WriteLine("Thank you for visiting us");
                        break;

                default:Console.WriteLine("Enter valid choice");
                        break;
            }

        }while(choice!=0);



    }
}