// See https://aka.ms/new-console-template for more information
using BOL;
using DAL;
using BLL;
using SAL;
//using System.Data;
//using MySql.Data.MySqlClient;
Console.WriteLine("Hello, World!");
///////////////////////////////////////////////////////////////////
// TEST PERSISTENT STORAGE FOR PRODUCTS AND USERS   //  SUCCESS
///////////////////////////////////////////////////////////////////
//ProductIOManager productIOManager = new ProductIOManager();
//
//CustomerIOManager productIOManager = new CustomerIOManager();
//The Relative Path to the file/ persistent storage
//string path = @"..\TFLStore\wwwroot\files\Products.json";
//productIOManager.Load(path);
// productIOManager.AddProduct(new Product("NAME", "DESCRIPTION", 90, 90));

// Console.WriteLine("After Adding");
// foreach (var product in products)
// {
//     Console.WriteLine(product);
// }
///////////////////////////////////////////////////////////////////
// Populate the MySql Table with file data  //  SUCCESS
///////////////////////////////////////////////////////////////////
// ProductDBManager productDBManager = new ProductDBManager();
// var products = productIOManager.GetAll();

// foreach(Product p in products){
// string conString = @"server=192.168.10.109;uid=dac25;password=welcome;database=dac25";
//         MySqlConnection con = new MySqlConnection(conString);
//         string query = "INSERT INTO PRODUCT(name,description,unitprice,quantity,imageurl) VALUES('"+p.Name+"','"+p.Description+"',"+p.UnitPrice+","+p.Quantity+",'"+p.ImageUrl+"')";
//         MySqlCommand cmd = new MySqlCommand();
//         cmd.Connection = con;
//         cmd.CommandText = query;
//         con.Open();
//         cmd.ExecuteNonQuery();

//         con.Close();
// }
////////////////////////////////////////////////////////////////////
//  TO TEST RETREIVAL OF DATA FROM MYSQL DATABASE   //  SUCCESS
//////////////////////////////////////////////////////////////////// 
// List<Product> products = new List<Product>();
//     string conString = @"server=192.168.10.109;uid=dac25;password=welcome;database=dac25";
//     MySqlConnection con = new MySqlConnection(conString);
//     string query = "SELECT * FROM PRODUCT";
//     MySqlCommand cmd = new MySqlCommand();
//     cmd.Connection = con;
//     cmd.CommandText = query;
//     con.Open();
//     MySqlDataReader reader = cmd.ExecuteReader();
//     while(reader.Read()){
//         int id = int.Parse(reader["id"].ToString());
//         string name = reader["name"].ToString();
//         string description = reader["description"].ToString();
//         double unitPrice = double.Parse(reader["unitprice"].ToString());
//         int quantity = int.Parse(reader["quantity"].ToString());
//         string imageUrl = reader["imageurl"].ToString();
//         Product product = new Product(id,name,description,unitPrice,quantity,imageUrl);
//         products.Add(product);
//     }
//     con.Close(); 
////////////////////////////////////////////////////////////////      
// foreach (var product in products)
// {
//     Console.WriteLine(product);
// } 
//////////////////////////////////////////////////////////////////
//  TEST ENTITY FRAMEWORK FOR PRODUCT OBJECT  // SUCCESS
//////////////////////////////////////////////////////////////////
//   POPULATE DATA FROM THE FILE INTO DATABASE  // SUCCESS
// ProductIOManager productIOManager = new ProductIOManager();
// var products = productIOManager.GetAll();
// ProductManager productManager = ProductManager.GetProductManager();
// foreach(Product p in products){
//     productManager.Insert(p);
// }
//////////////////////////////////////////////////////////////////
//  SEE DATA FROM TABLE WITH ENTITY FRAMEWORK  //  SUCCESS
// var products = productManager.GetAll();
// foreach(var product in products){
//     Console.WriteLine(product);
// } 
///////////////////////////////////////////////////////////////////
// POPULATE THE FILE FOR CATEGORIES AND ROLES  //
///////////////////////////////////////////////////////////////////
// CategoryIOManager categoryIOManager = new CategoryIOManager();
// List<Category> categories = categoryIOManager.GetAll();
// foreach(Category cat in categories){
//     Console.WriteLine(cat.Title);
//     categoryIOManager.AddCategory(cat);
// }
///////////////////////////////////////////////////////////////////
CartServices cartServices = new CartServices();
List<Cart> carts = cartServices.GetAllCarts(518733689);
foreach(var c in carts){
    Console.WriteLine(c.Id);
}
var cartitem = cartServices.GetCartById(15);
List<Cart> cart = cartServices.GetAllCarts(518733689);
List<CartView> cartview = cartServices.GetAllCartsView(518733689);
foreach(var c in cartview){
    Console.WriteLine(cartitem.Id + "-");
    Console.WriteLine(c.Id);
    if(cartitem.Id == c.Id){
        Console.WriteLine("Works");
    }
}

