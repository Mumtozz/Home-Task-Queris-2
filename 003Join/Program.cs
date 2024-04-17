using System.Security.Cryptography;
using _005.DataAnnotation.Data;

await using var dataContext = new DataContext();

Console.WriteLine("Good look  😊😊😊");

//1
//Получите все заказы с указанием имени клиента и количества заказа клиента.
//Get all orders with customer name and customer order quantity

// var res1 = (from oi in dataContext.OrderItems
//             join o in dataContext.Orders on oi.OrderId equals o.Id
//             join c in dataContext.Customers on o.CustomerId equals c.Id
//             select new {
//                 Quantity = oi.Quantity,
//                 Name = c.Name
//             });
            
           
//             foreach (var item in res1)
//                 System.Console.WriteLine($"{item.Name} {item.Quantity}");
            


//2
//Получить все заказы с именем клиента и стоимостью заказа
//Get all orders with customer name and order value


var res2 = (from oi in dataContext.OrderItems
            join o in dataContext.Orders on oi.OrderId equals o.Id
            join c in dataContext.Customers on o.CustomerId equals c.Id
            select new{
                    Name = c.Name,
                    Price = oi.Quantity * oi.Price,
            });

            foreach (var item in res2)
            {
                System.Console.WriteLine($"{item.Name} {item.Price}");
            }



//3
//Получите все заказы с указанием имени клиента и количества продукции
//Get all orders with customer name and product quantity:


var res3 = (from oi in dataContext.OrderItems
            join o in dataContext.Orders on oi.OrderId equals o.Id
            join c in dataContext.Customers on o.CustomerId equals c.Id
            select new{
                Name = c.Name,
                ProductQuantity = oi.ProductName.Count()
            });

foreach (var item in res3)
{
    System.Console.WriteLine($"{item.Name} {item.ProductQuantity}");
}

