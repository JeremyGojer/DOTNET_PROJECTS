// See https://aka.ms/new-console-template for more information
using BOL;
using DAL;
Console.WriteLine("Hello, World!");

ProductIOManager productIOManager = new ProductIOManager();
//CustomerIOManager productIOManager = new CustomerIOManager();
//The Relative Path to the file/ persistent storage
//string path = @"..\TFLStore\wwwroot\files\Products.json";
//productIOManager.Load(path);
// productIOManager.AddProduct(new Product("NAME", "DESCRIPTION", 90, 90));
var products = productIOManager.GetAll();
// Console.WriteLine("After Adding");
foreach (var product in products)
{
    Console.WriteLine(product);
}


        
        
