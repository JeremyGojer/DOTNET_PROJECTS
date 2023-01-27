namespace BOL;
using System.Collections;

public class SortProductByName:IComparer<Product>{
    public int Compare(Product prod1,Product prod2){
        return prod1.Name.CompareTo(prod2.Name);
    }
    
}