namespace BLL;
using BOL;
using DAL;

public class ProductManager{
    
    public static ProductManager instance = null;
    private ProductIOManager productIOManager = new ProductIOManager();
    private ProductManager(){

    }
    public static ProductManager GetProductManager(){
        if(instance == null){
            instance = new ProductManager();
        }
        return instance;
    }

    
    public List<Product> GetAll(){
        return productIOManager.GetAll();
    }

    public bool AddProduct(Product product){
        return productIOManager.AddProduct(product);
    }

    
    public bool RemoveProduct(Product product){
        return productIOManager.RemoveProduct(product);
    }

    
}