namespace SAL;
using System.Collections.Generic;
using BOL;
using BLL;

public class CategoryServices{
    private CategoryManager categoryManager = new CategoryManager();

    public List<Category> GetAllCategories(){
        return categoryManager.GetAll();
    }

    public bool AddToCategory(Category category){
        return categoryManager.AddToCategory(category);
    }


    public Category GetCategoryById(int id){
        var Categories = categoryManager.GetAll();
        foreach(var Category in Categories){
            if(Category.Id==id){
                return Category;
            }
        }
        return null;
    }

}