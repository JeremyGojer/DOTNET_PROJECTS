namespace BOL;

public class Product{
    public int Id {get;set;}
    public string Name {get;set;}
    public string Description {get;set;}
    public double UnitPrice {get;set;}
    public int Quantity {get;set;}
    public string ImageUrl {get;set;}
    
    public Product(string name, string description, double unitPrice, int quantity, string imageUrl)
    {
        Name = name;
        Description = description;
        UnitPrice = unitPrice;
        Quantity = quantity;
        ImageUrl = imageUrl;
    }

    public Product(int id, string name, string description, double unitPrice, int quantity, string imageUrl)
    {
        Id = id;
        Name = name;
        Description = description;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }

    public Product()
    {
    }

    public override string ToString()
    {
        return "\nID : "+Id+
               "\nNAME : "+Name+
               "\nDESCRIPTION : "+Description+
               "\nUNIT PRICE : "+UnitPrice+
               "\nQUANTITY : "+Quantity;
    }

    public override bool Equals(object obj)
    {
        return (obj as Product).Id == this.Id;
    }
}