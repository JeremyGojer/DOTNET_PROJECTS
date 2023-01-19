// See https://aka.ms/new-console-template for more information
using People;
using Catalog;

Console.WriteLine("Hello, World!");
Person p1 = new Person();
Person p2 = new Person("a","b",new DateTime(1970,01,01));
Employee e1 = new Employee(p1,1,"Developer","Alpha",10000);
SalesEmployee s1 = new SalesEmployee(e1,600,600,700);

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(e1);
Console.WriteLine(s1);