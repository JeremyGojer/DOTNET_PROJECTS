namespace SAL;
using System.Collections.Generic;
using BOL;
using BLL;

public class CartServices{
    private CartManager cartManager = new CartManager();

    public List<Cart> GetAllCarts(){
        return cartManager.GetAll();
    }

    public List<Cart> GetAllCarts(int userid){
        return cartManager.GetAll(userid);
    }
    public List<CartView> GetAllCartsView(int userid){
        return cartManager.GetAllView(userid);
    }

    public bool AddToCart(Cart cart){
        return cartManager.AddToCart(cart);
    }

    public bool RemoveFromCart(int id){
        return cartManager.RemoveFromCart(GetCartById(id));
    }

    public bool UpdateToCart(Cart cart){
        return cartManager.UpdateToCart(cart);
    }

    public Cart GetCartById(int id){
        var carts = cartManager.GetAll();
        foreach(Cart cart in carts){
            if(cart.Id==id){
                return cart;
            }
        }
        return null;
    }
    

}