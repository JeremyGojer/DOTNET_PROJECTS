namespace SAL;
using BOL;
using BLL;

public class OrderServices{

    private OrderManager orderManager = new OrderManager();

    public List<Order> GetAll(){
        return orderManager.GetAll();
    }

    public List<Order> GetAllForUser(int id){
        return orderManager.GetAllForUser(id);
    }

    public bool AddOrder(Order order){
        return orderManager.AddOrder(order);
    }

    public bool RemoveOrder(Order order){
        return orderManager.RemoveOrder(order);
    }

    public bool UpdateOrder(Order order){
        return orderManager.UpdateOrder(order);
    }
}