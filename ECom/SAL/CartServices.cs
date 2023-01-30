namespace SAL;
using System.Collections.Generic;
using BOL;
using BLL;

public class CartServices{
    private CartManager cartManager = new CartManager();

    public List<Cart> GetAllCarts(){
        return cartManager.GetAll();
    }

    public bool AddToCart(Cart cart){
        return cartManager.AddToCart(cart);
    }

    public bool RemoveFromCart(Cart cart){
        return cartManager.RemoveFromCart(cart);
    }

    public bool UpdateToCart(Cart cart){
        return cartManager.UpdateToCart(cart);
    }

    public Cart GetCartById(int id){
        var carts = cartManager.GetAll();
        foreach(var cart in carts){
            if(cart.Id==id){
                return cart;
            }
        }
        return null;
    }

}