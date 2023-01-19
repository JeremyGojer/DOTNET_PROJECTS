// See https://aka.ms/new-console-template for more information
using Catalog;
using CRM;
using Membership;
using OrderProcessing;
using System.Collections.Generic;

// Order o1 = new Order(1,"Dispatched",new DateTime(),1000);
// Order o2 = new Order(){OrderId=1, OrderDate=new DateTime(), Status="In Transist", OrderAmount=2000};

// List<Order> orders = new List<Order>();
// orders.Add(o1);
// orders.Add(o2);
// List<string> loc = new List<string>();
// loc.Add("Brooklyn");

// Customer c1 = new Customer(1,"Steve", "Rogers", "captain@avengers.com","1111111111",loc,orders);

// Console.WriteLine(c1);

Menu menu = new Menu();
menu.menu();

