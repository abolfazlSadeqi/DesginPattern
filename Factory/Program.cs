

Console.Write("Enter typePay: ");
string typePay = Console.ReadLine();

Console.Write("Enter Amount: ");

string Amount = Console.ReadLine();

Console.WriteLine(Factory.Classes.Instance.FactoryInstance.GetPayType(typePay, Amount));
