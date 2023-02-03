namespace BLL;
using DAL;
using BOL;

public class OrderManager{

    private DBEntityContext dBEntityContext = new DBEntityContext();

    public List<Order> GetAll(){
        var orders = from order in dBEntityContext.Orders select order;

        return orders.ToList<Order>();
    }

    public List<Order> GetAllForUser(int userid){
        var orders = from order in dBEntityContext.Orders where (order.UserId == userid) select order;

        return orders.ToList<Order>();
    }

    public bool AddOrder(Order order){
        bool status = false;
        List<Order> orders = GetAll();
        dBEntityContext.Orders.Add(order);
        dBEntityContext.SaveChanges();
        status = true;
        return status;

    }

    public bool RemoveOrder(Order order){
        bool status = false;
        List<Order> orders = GetAll();
        dBEntityContext.Orders.Remove(order);
        dBEntityContext.SaveChanges();
        status = true;
        return status;

    }

    public bool UpdateOrder(Order order){
        bool status = false;
        List<Order> orders = GetAll();
        dBEntityContext.Orders.Update(order);
        dBEntityContext.SaveChanges();
        status = true;
        return status;

    }


}