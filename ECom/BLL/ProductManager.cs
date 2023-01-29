namespace BLL;
using BOL;
using DAL;

public class ProductManager{
    
    public static ProductManager instance = null;
    //For File IO
    private ProductIOManager productIOManager = new ProductIOManager();
    //For DB Connected Access
    private ProductDBManager productDBManager = new ProductDBManager();
    // For Entity Framework
    private DBEntityContext dBEntityContext = new DBEntityContext();
    private ProductManager(){

    }
    public static ProductManager GetProductManager(){
        if(instance == null){
            instance = new ProductManager();
        }
        return instance;
    }

///////////////////////////////////////////////////////////////////////////
//    USING FILE IO TO FETCH DATA  //
///////////////////////////////////////////////////////////////////////////    
    // public List<Product> GetAll(){
    //     return productIOManager.GetAll();
    // }

    // public bool AddProduct(Product product){
    //     return productIOManager.AddProduct(product);
    // }

    public void SortByName(){
        productIOManager.SortByName();
    }

    public void SortByPrice(){
        productIOManager.SortByPrice();
    }
//////////////////////////////////////////////////////////////////////////
    public List<Product> GetAll(){
        var products = from product in dBEntityContext.Products select product;
        return products.ToList<Product>();
    }

    public bool AddProduct(Product product){
        bool status = false;
        dBEntityContext.Products.Add(product);
        dBEntityContext.SaveChanges();
        status = true;
        return status;
    }
// For testing purposes  // 
    // public bool Insert(Product product){
    //     bool status = false;
    //     dBEntityContext.Products.Add(product);
    //     dBEntityContext.SaveChanges();
    //     status = true;
    //     return status;
    // } 

    public bool RemoveProduct(Product product){
        bool status = false;
        dBEntityContext.Products.Remove(product);
        dBEntityContext.SaveChanges();
        status = true;
        return status;
    }

    public bool UpdateProduct(Product product){
        bool status = false;
        dBEntityContext.Products.Update(product);
        dBEntityContext.SaveChanges();
        status = true;
        return status;
    }

}