namespace SAL;
using System.Collections.Generic;
using BOL;

public class ProductServices:IProductServices{
    public List<Product> DisplayAllProducts(){
        var products = new List<Product>();
        products.Add(new Product(1,"Gerbera","Wedding Flower",500,45));
        products.Add(new Product(2,"Rose","Valentine Flower",500,45));
        products.Add(new Product(3,"Tulip","Bright Flower",500,45));
        products.Add(new Product(4,"Lotus","Holy Flower",500,45));
        products.Add(new Product(5,"Jasmine","Fragrance Flower",500,45));
        products.Add(new Product(6,"Sunflower","WellBeing Flower",500,45));
        products.Add(new Product(7,"Orchid","Nice Flower",500,45));
        return products;
    }
}