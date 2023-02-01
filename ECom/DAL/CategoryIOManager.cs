namespace DAL;
using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class CategoryIOManager
{
    private string path=@"..\MyEComApp\wwwroot\files\Categories.json";
    //In case we need to get data from a different file pass it through the constructor
    public CategoryIOManager(string path)
    {
        this.path = path;
    }

    public CategoryIOManager()
    {
    }

    public List<Category> GetAll()
    {
        
        List<Category> categories = Load(this.path);
        if (categories == null)
        {
            categories = new List<Category>();
            categories.Add(new Category{Id=1,Title="Electronics"});
            categories.Add(new Category{Id=2,Title="Fashion"});
            categories.Add(new Category{Id=3,Title="Decorations"});
        }
        return categories;
    }

    public bool Save(string path, List<Category> categories)
    {
        
        bool status = false;
        string jsonString = JsonSerializer.Serialize(categories);
        File.WriteAllText(path, jsonString);
        return true;
    }

    public List<Category> Load(string path)
    {
        string json = File.ReadAllText(path);
        List<Category> categories = JsonSerializer.Deserialize<List<Category>>(json);
        return categories;
    }

    public bool AddCategory(Category category)
    {
        bool status = false;
        
        try
        {
            List<Category> categories = Load(this.path);
            categories.Add(category);
            Save(this.path, categories);
            status = true;
            return status;
        }
        catch (Exception e)
        {
            return status;
        }

    }

    
    
}