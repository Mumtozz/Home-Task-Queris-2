using _005.DataAnnotation.Data;

await using var dataContext = new DataContext();


Console.WriteLine("Good look  😊😊😊");

//1
//Получить все заказы, сделанные клиентом с именем "Ahmad", а также все заказы, в которых был заказан товар с названием "Water"
//Retrieve all orders placed by a customer named "Ahmad" as well as all orders that included a product named "Water"


var res = dataContext.OrderItems.Where(e => e.Order!.Customer!.Name == "Ahmad" && e.ProductName == "Banana");
foreach (var item in res)
{
    System.Console.WriteLine($"{item.Id} {item.OrderId} {item.Price} {item.ProductName} {item.Quantity}");
}




//2
//Получить все заказы, сделанные клиентом с именем "Akmal", а также все заказы, в которых был заказан товар с названием "Banana"
//Retrieve all orders placed by a customer named "Akmal" as well as all orders that included a product named "Banana"

var res2 = dataContext.OrderItems.Where(e => e.Order!.Customer!.Name == "Akmal" && e.ProductName == "Banana");
foreach (var item in res2)
{
    System.Console.WriteLine($"{item.Id} {item.OrderId} {item.Price} {item.ProductName} {item.Quantity}");
}




dataContext.Database.EnsureDeleted();