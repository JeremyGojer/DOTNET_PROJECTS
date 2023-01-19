namespace Utility;
using Banking;
//delegate only works on function with same signature as AutoResponse
public delegate void AutoResponse(Account acc);
public delegate void SuccessResponse();
public class Handler
{
    public static void PayIncomeTax(Account acc){
        acc.Balance *= 0.85;
        Console.WriteLine("15% of tax is deducted");
    }

    public static void PayServiceTax(Account acc){
        acc.Balance *= 0.90;
        Console.WriteLine("10% of tax id deducted");
    }

    public static void SendEmail(Account acc){
        Console.WriteLine("Email Sent to "+acc.AccountName);
    }

    public static void SendSMS(Account acc){
        Console.WriteLine("SMS sent to "+acc.AccountName);
    }

    public static void BlockAcc(Account acc){
        Console.WriteLine("Account Blocked for "+acc.AccountName+" please contact branch "+acc.BranchCode+" immediately");
    }
    public static void Success(Account acc){
        Console.WriteLine("Your current transaction was sucessful for account "+acc.AccountId+" check balance to confirm");
    }

}
