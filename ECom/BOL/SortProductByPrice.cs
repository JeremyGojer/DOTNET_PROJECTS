namespace BOL;
using System.Collections;

public class SortProductByPrice:IComparer<Product>{
    public int Compare(Product prod1,Product prod2){
        return prod1.UnitPrice.CompareTo(prod2.UnitPrice);
    }

}