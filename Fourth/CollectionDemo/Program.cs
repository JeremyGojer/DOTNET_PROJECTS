
using System.Collections.Generic;

////////////////-----LIST DEMO----------///////////////////////
// var is used only for convinence
var fruits = new List<string>();
fruits.Add("Apple");
fruits.Add("Banana");
fruits.Add("Cheery");
fruits.Add("Strawberry");

foreach (var fruit in fruits){
    Console.WriteLine(fruit);
}
/////////////////------LINKEDLIST DEMO------------//////////////////////////
var vegetables = new LinkedList<string>();
vegetables.AddFirst("Potato");
vegetables.AddLast("Green Beans");
foreach (var vegetable in vegetables){
 
    Console.WriteLine(vegetable);
}
/////////////////-------BALANCED ARRAY DEMO-----------/////////////////////////

Pixel [,] pixels = new Pixel[2,2]{
                        {new Pixel(2,2,2),new Pixel(3,3,3)},
                        {new Pixel(4,4,4),new Pixel(5,5,5)}
                        };


for(int i=0;i<2;i++){
    for(int j=0;j<2;j++){
        Console.Write(pixels[i,j]);
    }   
    Console.WriteLine();
}
