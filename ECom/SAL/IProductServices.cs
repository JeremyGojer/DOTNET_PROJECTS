namespace SAL;
using System.Collections.Generic;
using BOL;
public interface IProductServices{

    public List<Product> GetAllProducts();
    public List<Product> GetAllProducts(int id);

    public bool AddProduct(Product product);

    public bool RemoveProduct(Product product);

    public bool UpdateProduct(Product product);
    public Product GetProductById(int id);
    public void SortByName();
    public void SortByPrice();
}