namespace SAL;
using System.Collections.Generic;
using BOL;
using BLL;

public class ProductServices:IProductServices{
    private ProductManager productManager = ProductManager.GetProductManager();

    public List<Product> GetAllProducts(){
        return productManager.GetAll();
    }

    public bool AddProduct(Product product){
        return productManager.AddProduct(product);
    }

    public bool RemoveProduct(Product product){
        return productManager.RemoveProduct(product);
    }

    public bool UpdateProduct(Product product){
        return productManager.UpdateProduct(product);
    }

    public Product GetProductById(int id){
        var products = productManager.GetAll();
        foreach(var product in products){
            if(product.Id==id){
                return product;
            }
        }
        return null;
    }
    public void SortByName(){
        productManager.SortByName();
    }

    public void SortByPrice(){
        productManager.SortByPrice();
    }
}