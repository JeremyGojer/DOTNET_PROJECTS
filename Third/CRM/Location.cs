namespace CRM;
using System.Collections.Generic;
using Banking;
public class Location
{
    //Locations DETAILS ARE PRESENT HERE FIND LIST OF REGIONAL ACCOUNTS USING THIS
    public string BranchCode {get;set;}
    public string Location_City {get;set;}
    public List<Account> AccountHolders{get;set;}

    public Location()
    {
        BranchCode = "PDFC0001";;
        Location_City = "Pune";
        AccountHolders = new List<Account>();
    }

    public Location(string branchCode, string Location_City, List<Account> accountHolders)
    {
        BranchCode = branchCode;
        Location_City = Location_City;
        AccountHolders = accountHolders;
    }

    public override string ToString()
    {
        return "\n"+BranchCode+" - "+Location_City+" - "+AccountHolders.Count();
    }


}
