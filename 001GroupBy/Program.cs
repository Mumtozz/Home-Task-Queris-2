using _001GroupBy;
using _005.DataAnnotation.Data;

await using var dataContext = new DataContext();


Console.WriteLine("Good look  😊😊😊");

//1
//Получить количество заказов для каждого клиента
//Get the number of orders for each customer


// var res = dataContext.Orders.GroupBy(e => e.Customer).Select(g => new {Customer = g.Key,CountOfOrder = g.Count()});
// foreach (var item in res)
//     System.Console.WriteLine($"{item.Customer.Name} {item.CountOfOrder}");


//2
//Получить общую стоимость заказов для каждого клиента
//Get the total cost of orders for each customer



var res2 = dataContext.OrderItems.GroupBy(e => e.Order.Customer).Select(g => new {Customer = g.Key, Sum = g.Sum(e => e.Price)});

foreach (var item in res2)
{
    System.Console.WriteLine($"{item.Customer.Name} {item.Sum}");
}





// var res2 = dataContext.OrderItems.GroupBy(e => e.Order).Select(g => new {Order = g.Key,TotalCost = g.Sum(e => e.Price)});



// foreach (var item in res2)
//     System.Console.WriteLine($"{item.Order.Customer.Name} {item.TotalCost}");



//3
//Получить среднюю стоимость заказов для каждого клиента
//Get the average order value for each customer


var res3 = dataContext.OrderItems.GroupBy(e => e.Order.Customer).Select(g => new {Customer = g.Key,Average = g.Average(e => e.Price)});
foreach (var item in res3)
{
    System.Console.WriteLine($"{item.Customer.Name} {item.Average}");
}


