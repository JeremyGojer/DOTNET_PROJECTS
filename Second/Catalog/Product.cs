namespace Catalog;
public class Product{
    public int ProductId {get;set;}
    public String ProductName {get;set;}
    public String ProductDescription {get;set;}
    public double UnitPrice {get;set;}
    public int CategoryId {get;set;}

    public Product(){
        this.ProductId = 0;
        this.ProductName = "test";
        this.ProductDescription = "test product";
        this.UnitPrice = 100;
        this.CategoryId = 0;
    }

    public Product(int productId, string productName, string productDescription, double unitPrice, int categoryId)
    {
        this.ProductId = productId;
        this.ProductName = productName;
        this.ProductDescription = productDescription;
        this.UnitPrice = unitPrice;
        this.CategoryId = categoryId;
    }

    public override string ToString()
    {
        return base.ToString() + "\n" + this.ProductId 
                                + "\n" + this.ProductName
                                + "\n" + this.ProductDescription
                                + "\n" + this.UnitPrice
                                + "\n" + this.CategoryId;
    }
}
