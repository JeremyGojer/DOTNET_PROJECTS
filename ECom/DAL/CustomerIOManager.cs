namespace DAL;
using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class CustomerIOManager{
    private string path=@"C:\customers\iet\Desktop\reopo\DOTNET_PROJECTS\ECom\TFLStore\wwwroot\files\Customers.json";

    public List<Product> GetAll()
    {
        List<Product> customers = Load(this.path);
        // if (customers == null)
        // {
        //     customers.Add(new Product(1, "Gerbera", "Wedding Flower", 500, 45));
        //     customers.Add(new Product(2, "Rose", "Valentine Flower", 500, 45));
        //     customers.Add(new Product(3, "Tulip", "Bright Flower", 500, 45));
        //     customers.Add(new Product(4, "Lotus", "Holy Flower", 500, 45));
        //     customers.Add(new Product(5, "Jasmine", "Fragrance Flower", 500, 45));
        //     customers.Add(new Product(6, "Sunflower", "WellBeing Flower", 500, 45));
        //     customers.Add(new Product(7, "Orchid", "Nice Flower", 500, 45));
        // }
        return customers;
    }

    public bool Save(string path, List<Product> customers)
    {
        
        bool status = false;
        string jsonString = JsonSerializer.Serialize(customers);
        File.WriteAllText(path, jsonString);
        return true;
    }

    public List<Product> Load(string path)
    {
        string json = File.ReadAllText(path);
        List<Product> customers = JsonSerializer.Deserialize<List<Product>>(json);
        return customers;
    }

    public bool AddProduct(Product product)
    {
        bool status = false;
        
        try
        {
            List<Product> customers = Load(this.path);
            customers.Add(product);
            Save(this.path, customers);
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
            List<Product> customers = Load(this.path);
            foreach(var prod in customers){
                if(product.Id==prod.Id){

                }
            }
            Save(this.path, customers);
            status = true;
            return status;
        }
        catch (Exception e)
        {
            return status;
        }

    }
}