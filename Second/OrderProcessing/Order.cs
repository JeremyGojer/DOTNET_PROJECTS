namespace OrderProcessing;
public class Order{
    public int OrderId {get;set;}
    public string Status {get;set;}
    public DateTime OrderDate {get;set;}
    public double OrderAmount {get;set;}

    public Order(int orderId, string status, DateTime orderDate, double orderAmount)
    {
        this.OrderId = orderId;
        this.Status = status;
        this.OrderDate = orderDate;
        this.OrderAmount = orderAmount;
    }

    public Order(){
        this.OrderId = 0;
        this.Status = "Done";
        this.OrderDate = new DateTime();
        this.OrderAmount = 100;
    }

    public override string ToString()
    {
        return base.ToString() + "\n" + this.OrderId
                                + "\n" + this.Status
                                + "\n" + this.OrderDate
                                + "\n" + this.OrderAmount;
    }

}
