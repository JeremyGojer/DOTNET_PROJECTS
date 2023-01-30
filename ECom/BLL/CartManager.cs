namespace BLL;
using BOL;
using DAL;

public class CartManager{
    
    private DBEntityContext dBEntityContext = new DBEntityContext();
    

    public List<Cart> GetAll(){
        var carts = from cart in dBEntityContext.Carts select cart;
        return carts.ToList<Cart>();
    }

    public bool AddToCart(Cart cart){
        bool status = false;
        dBEntityContext.Carts.Add(cart);
        dBEntityContext.SaveChanges();
        status = true;
        return status;
    }

    public bool RemoveFromCart(Cart cart){
        bool status = false;
        dBEntityContext.Carts.Remove(cart);
        dBEntityContext.SaveChanges();
        status = true;
        return status;
    }

    public bool UpdateToCart(Cart cart){
        bool status = false;
        dBEntityContext.Carts.Update(cart);
        dBEntityContext.SaveChanges();
        status = true;
        return status;
    }   

}