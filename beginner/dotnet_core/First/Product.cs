namespace Catalog;

public class Product{
    
    int ProductId {get;set;}
    string ProductName {get;set;}
    string Description {get;set;}
    double UnitPrice {get;set;}
    int CategoryId {get;set;}

    public Product(){
        this.ProductName = "test";
        this.Description = "This is a test entry";
        this.UnitPrice = 1000;
        this.CategoryId = 0;
    }

    public Product(string name, string desc, double price, int catid){
        this.ProductName = name;
        this.Description = desc;
        this.UnitPrice = price;
        this.CategoryId = catid;
    }

    public override string ToString(){
        return base.ToString() + " " + this.ProductName + " " + this.Description + " " + this.UnitPrice + " " + this.CategoryId;
    }

    
}