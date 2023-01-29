namespace BLL;
using BOL;
using DAL;

public class CartManager{
    
    public static CartManager instance = null;
    private DBEntityContext dBEntityContext = new DBEntityContext();
    private CartManager(){

    }
    public static CartManager GetCartManager(){
        if(instance == null){
            instance = new CartManager();
        }
        return instance;
    }

    public List<Cart> GetAll(){
        var Carts = from Cart in dBEntityContext.Carts select Cart;
        return Carts.ToList<Cart>();
    }

    public bool AddToCart(Cart Cart){
        bool status = false;
        dBEntityContext.Carts.Add(Cart);
        dBEntityContext.SaveChanges();
        status = true;
        return status;
    }

    public bool RemoveFromCart(Cart Cart){
        bool status = false;
        dBEntityContext.Carts.Remove(Cart);
        dBEntityContext.SaveChanges();
        status = true;
        return status;
    }

    public bool UpdateToCart(Cart Cart){
        bool status = false;
        dBEntityContext.Carts.Update(Cart);
        dBEntityContext.SaveChanges();
        status = true;
        return status;
    }   

}