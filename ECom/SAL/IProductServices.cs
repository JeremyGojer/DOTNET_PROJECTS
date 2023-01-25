namespace SAL;
using System.Collections.Generic;
using BOL;
public interface IProductServices{

    public List<Product> GetAllProducts();

    public bool AddProduct(Product product);

    public bool RemoveProduct(Product product);
    public Product GetProductById(int id);
}