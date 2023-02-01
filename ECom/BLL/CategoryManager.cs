namespace BLL;
using BOL;
using DAL;

public class CategoryManager{

    private CategoryIOManager  categoryIOManager = new CategoryIOManager();
    public List<Category> GetAll(){
        return categoryIOManager.GetAll();
    }

    public bool AddToCategory(Category Category){
        return categoryIOManager.AddCategory(Category);
    }

    public Category GetCategoryById(int id){
        List<Category> categories = GetAll();
        Category category = categories.FirstOrDefault(category => category.Id == id);
        return category;

    }
}