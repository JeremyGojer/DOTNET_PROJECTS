namespace SAL;
using System.Collections.Generic;
using BOL;
using BLL;

public class ProductServices:IProductServices{
    private ProductManager productManager = ProductManager.GetProductManager();

    // public List<Product> DisplayAllProducts(){
    //     var products = new List<Product>();
    //     products.Add(new Product("Gerbera","Wedding Flower",500,45));
    //     products.Add(new Product("Rose","Valentine Flower",500,45));
    //     products.Add(new Product("Tulip","Bright Flower",500,45));
    //     products.Add(new Product("Lotus","Holy Flower",500,45));
    //     products.Add(new Product("Jasmine","Fragrance Flower",500,45));
    //     products.Add(new Product("Sunflower","WellBeing Flower",500,45));
    //     products.Add(new Product("Orchid","Nice Flower",500,45));
    //     return products;
    // }

    public List<Product> GetAllProducts(){
        return productManager.GetAll();
    }

    public bool AddProduct(Product product){
        return productManager.AddProduct(product);
    }

    public bool RemoveProduct(Product product){
        return productManager.RemoveProduct(product);
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
}