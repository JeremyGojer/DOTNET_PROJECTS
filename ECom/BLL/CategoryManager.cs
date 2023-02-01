namespace BLL;
using BOL;
using DAL;

public class CategoryManager{
    public static CategoryManager instance = null;
    private CategoryIOManager categoryIOManager= new CategoryIOManager();
    
    private CategoryManager(){

    }
    public static CategoryManager GetCategoryManager(){
        
        if(instance==null){
            instance = new CategoryManager();
        }
        return instance;
    }

    public List<Category> GetAll(){
        return categoryIOManager.GetAll();
    }

    public bool AddCategory(Category Category){
        return categoryIOManager.AddCategory(Category);
    }


}