namespace BOL;
public class Product{
    public int Id {get;set;}
    public string Name {get;set;}
    public string Description {get;set;}
    public double UnitPrice {get;set;}
    public int Quantity {get;set;}

    public Product(int id, string name, string description, double unitPrice, int quantity)
    {
        Id = id;
        Name = name;
        Description = description;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return "\nID : "+Id+
               "\nNAME : "+Name+
               "\nDESCRIPTION : "+Description+
               "\nUNIT PRICE : "+UnitPrice+
               "\nQUANTITY : "+Quantity;
    }
}