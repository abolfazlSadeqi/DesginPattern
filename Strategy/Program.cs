using Strategy.Classes.Service;


var _product = new Strategy.Classes.Domin.ProductModel() { Id = 1, Name = "test", CategoryId = 1, Factory = "F1", Price = 250 };

ContextDocSerialization processor = new ContextDocSerialization(new Text());
Console.WriteLine("Text");
Console.WriteLine( processor.ProcessingComplete(_product));
Console.WriteLine("-----");

Console.WriteLine("Json");
processor.SwitchStrategy(new Json());
Console.WriteLine( processor.ProcessingComplete(_product));
Console.WriteLine("-----");

Console.WriteLine("Xml");
processor.SwitchStrategy(new Xml());
Console.WriteLine( processor.ProcessingComplete(_product));
Console.WriteLine("-----");
Console.ReadKey();