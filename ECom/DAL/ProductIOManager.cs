namespace DAL;
using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class ProductIOManager
{
    private string path=@"..\MyEComApp\wwwroot\files\Products.json";
    //In case we need to get data from a different file pass it through the constructor
    public ProductIOManager(string path)
    {
        this.path = path;
    }

    public ProductIOManager()
    {
    }

    public List<Product> GetAll()
    {
        
        List<Product> products = Load(this.path);
        // if (products == null)
        // {
        //     products.Add(new Product(1, "Gerbera", "Wedding Flower", 500, 45));
        //     products.Add(new Product(2, "Rose", "Valentine Flower", 500, 45));
        //     products.Add(new Product(3, "Tulip", "Bright Flower", 500, 45));
        //     products.Add(new Product(4, "Lotus", "Holy Flower", 500, 45));
        //     products.Add(new Product(5, "Jasmine", "Fragrance Flower", 500, 45));
        //     products.Add(new Product(6, "Sunflower", "WellBeing Flower", 500, 45));
        //     products.Add(new Product(7, "Orchid", "Nice Flower", 500, 45));
        // }
        return products;
    }

    public bool Save(string path, List<Product> products)
    {
        
        bool status = false;
        string jsonString = JsonSerializer.Serialize(products);
        File.WriteAllText(path, jsonString);
        return true;
    }

    public List<Product> Load(string path)
    {
        string json = File.ReadAllText(path);
        List<Product> products = JsonSerializer.Deserialize<List<Product>>(json);
        return products;
    }

    public bool AddProduct(Product product)
    {
        bool status = false;
        
        try
        {
            List<Product> products = Load(this.path);
            products.Add(product);
            Save(this.path, products);
            status = true;
            return status;
        }
        catch (Exception e)
        {
            return status;
        }

    }

    public bool RemoveProduct(Product product)
    {
        bool status = false;
       
        try
        {
            List<Product> products = Load(this.path);
            foreach(var prod in products){
                if(product.Id==prod.Id){

                }
            }
            Save(this.path, products);
            status = true;
            return status;
        }
        catch (Exception e)
        {
            return status;
        }

    }
    public void SortByName(){
        List<Product> products = Load(this.path);
        IComparer<Product> sortbyname = new SortProductByName();
        products.Sort(sortbyname);
        Save(this.path,products);
    }

    public void SortByPrice(){
        List<Product> products = Load(this.path);
        IComparer<Product> sortbyprice = new SortProductByPrice();
        products.Sort(sortbyprice);
        Save(this.path,products);
    }
}