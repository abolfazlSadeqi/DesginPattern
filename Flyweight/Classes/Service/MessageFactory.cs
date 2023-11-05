using Flyweight.Classes.Domin;
using Flyweight.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes.Service;


public class MessageFactory
{
    private readonly Dictionary<LanguageType, ICustomMessage> customMessage = new Dictionary<LanguageType, ICustomMessage>();
    public MessageFactory()
    {
        CreateInstance();
    }

    public ICustomMessage? GetCustomMessage(LanguageType key) => customMessage.ContainsKey(key) ? customMessage[key] : null;


    private void CreateInstance()
    {
        customMessage.Add(LanguageType.English, new EnglishMessage());
        customMessage.Add(LanguageType.Persian, new PersianMessage());
        customMessage.Add(LanguageType.Kurdish, new KurdishMessage());

    }
}