namespace Banking;
using Utility;
public class Account:Transaction
{
    public string AccountId {get;set;}
    public string AccountName {get;set;}
    public string BranchCode {get;set;}
    public double Balance {get;set;}

    public Account()
    {
        //BANK NAME + YEAR + 8 DIGIT UID
        AccountId = "PDFC2023";
        AccountName = "PDFC";
        BranchCode = "PDFC0001";
        Balance = 10000;
    }

    public Account(string accountName, string branchCode, double balance)
    {
        AccountId = "test";
        AccountName = accountName;
        BranchCode = branchCode;
        Balance = balance;
    }
    //creating event for tax cuts
    public event AutoResponse TaxCuts;
    //creating event for sucessful transaction
    public event SuccessResponse Success;

    public void Deposit(double amount){
        this.Balance += amount;
        if(this.Balance <= 250000){
            Success(this);
        }
        else{
            // Calling this event will trigger a series of delegate calls
            TaxCuts(this);
        }
    }
    //creating event for Under Balance
    public event AutoResponse UnderBalance;

    public void Withdraw(double amount){
        this.Balance -= amount;
        if(this.Balance >= 10000){
            Success(this);
        }
        else{
            // Calling this event will trigger a series of delegate calls
            UnderBalance(this);
        }
    }

    public override string ToString()
    {
        return  "\n******************************************************"+
                "\n*                    PDFC BANK                       *"+
                "\n******************************************************"+
                "\n*\n*\n*\n*"+
                "\n*Account ID : "+AccountId+
                "\n*Name of Account Holder : "+AccountName+
                "\n*Branch Code : "+BranchCode+
                "\n*Balance : "+Balance+
                "\n*\n*\n*\n*"+
                "\n******************************************************"+
                "\n*            The Only Bank you should trust          *"+
                "\n******************************************************";
    }
}
