namespace DAL;
using BOL;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

public class ProductDBManager{

    public List<Product> GetAll(){
        List<Product> products = new List<Product>();
        string conString = @"server=192.168.10.109;uid=dac25;password=welcome;database=dac25";
        MySqlConnection con = new MySqlConnection(conString);
        string query = "SELECT * FROM PRODUCT";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = query;
        con.Open();
        MySqlDataReader reader = cmd.ExecuteReader();
        while(reader.Read()){
            int id = int.Parse(reader["id"].ToString());
            string name = reader["name"].ToString();
            string description = reader["description"].ToString();
            double unitPrice = double.Parse(reader["unitprice"].ToString());
            int quantity = int.Parse(reader["quantity"].ToString());
            string imageUrl = reader["imageurl"].ToString();
            Product product = new Product(id,name,description,unitPrice,quantity,imageUrl);
            products.Add(product);

        }
        con.Close();
        return products;
    }


}