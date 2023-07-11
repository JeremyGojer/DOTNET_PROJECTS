using Classroom;
using meth;

Console.WriteLine("Hello, World!");
var num1 = 10;
var num2 = 20;
Console.WriteLine(num1+num2);
Student s = new Student{
    FirstName = "Hello",
    LastName = "World",
    DOB = new DateTime(2006,12,5)
};

Console.WriteLine(s);

Complex a = new Complex(1, 2);
Complex b = new Complex(3, 4);

Console.WriteLine(a*b);