namespace SAL;
using System.Collections.Generic;
using BOL;
using BLL;

public class CartServices{
    private CartManager CartManager = CartManager.GetCartManager();

    public List<Cart> GetAllCarts(){
        return CartManager.GetAll();
    }

    public bool AddToCart(Cart Cart){
        return CartManager.AddToCart(Cart);
    }

    public bool RemoveFromCart(Cart Cart){
        return CartManager.RemoveFromCart(Cart);
    }

    public bool UpdateToCart(Cart Cart){
        return CartManager.UpdateToCart(Cart);
    }

    public Cart GetCartById(int id){
        var Carts = CartManager.GetAll();
        foreach(var Cart in Carts){
            if(Cart.Id==id){
                return Cart;
            }
        }
        return null;
    }

}