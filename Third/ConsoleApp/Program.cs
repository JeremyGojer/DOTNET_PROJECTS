// See https://aka.ms/new-console-template for more information
using Utility;
using Banking;

int choice = 0;
Account acc = new Account();


do{
    Console.WriteLine("\nEnter Choice"+
                      "\n1. Add User"+
                      "\n2. Deposit"+
                      "\n3. Withdraw"+
                      "\n4. Show Statement"+
                      "\n0. Exit");
    choice = Int32.Parse(Console.ReadLine());

    switch(choice){
        
        //Adds a new account 
        case 1: Console.WriteLine("Enter Name");
                string accName = Console.ReadLine();
                Console.WriteLine("Enter Branch Code");
                string branchCode = Console.ReadLine();
                Console.WriteLine("Enter Initial Amount to be deposited");
                double balance = Double.Parse(Console.ReadLine());
                acc = new Account(accName,branchCode,balance);
                //Here we create delegates for events

                AutoResponse payIncomeTax = new AutoResponse(Handler.PayIncomeTax);
                AutoResponse payServiceTax = new AutoResponse(Handler.PayServiceTax);
                AutoResponse sendEmail = new AutoResponse(Handler.SendEmail);
                AutoResponse sendSMS = new AutoResponse(Handler.SendSMS);
                AutoResponse blockAccount = new AutoResponse(Handler.BlockAcc);
                SuccessResponse success = new SuccessResponse(Handler.Success);

                //We create multicast delegate for our purpose
                // the only symbols to work with delegate objects are += and -=

                AutoResponse deposit = payIncomeTax;
                deposit +=  payServiceTax;
                deposit +=  sendEmail;
                deposit +=  sendSMS;
                deposit +=  success;
                AutoResponse withdraw = blockAccount;
                withdraw += sendEmail;
                withdraw += sendSMS;
                withdraw += success;

                /////////////////////////////////////////
                //Higher Balance leads to taxcuts
                acc.TaxCuts += deposit;
                //Lower Balance leads to blocking of account
                acc.UnderBalance += withdraw;
                break;

        //Deposit funds in account
        case 2: Console.WriteLine("Enter Account No");
                string accNo = Console.ReadLine();
                Console.WriteLine("Enter Amount to Deposit");
                double amount = Double.Parse(Console.ReadLine());
                acc.Deposit(amount);
                break;

        //Withdraw funds from account
        case 3: Console.WriteLine("Enter Account No");
                accNo = Console.ReadLine();
                Console.WriteLine("Enter Amount to Withdraw");
                amount = Double.Parse(Console.ReadLine());
                acc.Withdraw(amount);
                break;

        //Show Balance
        case 4: Console.WriteLine("Enter your AccountNo");
                accNo = Console.ReadLine();
                Console.WriteLine(acc);
                break;

        case 0: Console.WriteLine("Thank you for banking with us");
                break;

        default:Console.WriteLine("Enter Valid Choice");
                break;
    }

}while(choice!=0);


