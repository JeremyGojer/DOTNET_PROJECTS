namespace BOL;

// This is the class built just for handling the cart view, there is no table related to this in db
public class CartView{
    public int Id{get;set;}
    public int UserId{get;set;}
    public string ProductName{get;set;}
    public int Quantity{get;set;}
    public double UnitPrice{get;set;}
}