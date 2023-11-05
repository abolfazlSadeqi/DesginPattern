using Flyweight.Classes.Service;


MessageFactory factory = new MessageFactory();


var messageFactoryEnglish = factory.GetCustomMessage(Flyweight.Classes.Domin.LanguageType.English);

Console.WriteLine("MessageEnglish=" + messageFactoryEnglish.GetMessage(Flyweight.Classes.Domin.MessageType.Empty));

var messageFactoryKurdish = factory.GetCustomMessage(Flyweight.Classes.Domin.LanguageType.Kurdish);

Console.WriteLine("MessageKurdish=" + messageFactoryKurdish.GetMessage(Flyweight.Classes.Domin.MessageType.Empty));

var messageFactoryPersian = factory.GetCustomMessage(Flyweight.Classes.Domin.LanguageType.Persian);

Console.WriteLine("MessagePersian=" + messageFactoryPersian.GetMessage(Flyweight.Classes.Domin.MessageType.Empty));

Console.ReadKey();