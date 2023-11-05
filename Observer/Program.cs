using Observer.Classes.Domin;
using Observer.Classes.Service;
using Observer.Classes.interfaces;

ProductModel productModel = new ProductModel() { Id = 1, Name = "Test", CategoryId = 12, Factory = "ddd", Price = 80 };
ISubject _Stock = new Stock(productModel);

IObserver _CustomerAgenttest = new CustomerAgentObserver(new CustomerAgentModel() { Id = 1, Name = "test", PhoneNumber = "123475544" }, _Stock);
IObserver _CustomerAgenttest2 = new CustomerAgentObserver(new CustomerAgentModel() { Id = 1, Name = "test2", PhoneNumber = "12345544" }, _Stock);
IObserver _CustomerAgenttest3 = new CustomerAgentObserver(new CustomerAgentModel() { Id = 1, Name = "test3", PhoneNumber = "12345544" }, _Stock);


_Stock.Remove(_CustomerAgenttest2);
productModel.Price = 102;
_Stock.UpdatePrice(productModel);
Console.ReadLine();