namespace DAL;
using Microsoft.EntityFrameworkCore;
using BOL;

// This is for using Entity Framework
public class DBEntityContext:DbContext{

//Mapping Table with the BOL class
    public DbSet<Product> Products {get;set;}
    public DbSet<Cart> Carts {get;set;}
    public DbSet<Role> Roles {get;set;}
    public DbSet<Role> Categories {get;set;}

// To pass the conString to make connection with database
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        string conString = @"server=127.0.0.1;uid=Jeremy;password=Jeremy;database=flowersapp";
        //string conString = @"server=192.168.10.109;uid=dac25;password=welcome;database=dac25";
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.UseMySQL(conString);
    }
}