

using Bridge.Classes.Service.Abstraction;
using Bridge.Classes.Service.Implementation;
using Iterator.Classes.Domin;

OrderProduct orderproduct = new OrderProduct(new JsonSave());

Product product = new Product { Id = 1001, Code = "ss" };
Console.WriteLine( orderproduct.SaveContent(product));
