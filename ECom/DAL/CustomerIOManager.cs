namespace DAL;
using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class CustomerIOManager{
    private string path=@"..\TFLStore\wwwroot\files\Customers.json";

    public List<Customer> GetAll()
    {
        List<Customer> customers = Load(this.path);
        if (customers == null)
        {
            customers.Add(new Customer("Jeremy", "Gojer", "gojerjeremy@gmail.com", "Jeremy", "7019294131"));
            
        }
        return customers;
    }

    public bool Save(string path, List<Customer> customers)
    {
        
        bool status = false;
        string jsonString = JsonSerializer.Serialize(customers);
        File.WriteAllText(path, jsonString);
        return true;
    }

    public List<Customer> Load(string path)
    {
        string json = File.ReadAllText(path);
        List<Customer> customers = JsonSerializer.Deserialize<List<Customer>>(json);
        return customers;
    }

    public bool AddCustomer(Customer customer)
    {
        bool status = false;
        
        try
        {
            List<Customer> customers = Load(this.path);
            customers.Add(customer);
            Save(this.path, customers);
            status = true;
            return status;
        }
        catch (Exception e)
        {
            return status;
        }

    }

    public bool RemoveCustomer(Customer customer)
    {
        bool status = false;
       
        return false;

    }
}