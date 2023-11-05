using Flyweight.Classes.Domin;
using Flyweight.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes.Service;

public class EnglishMessage : ICustomMessage
{

    public string GetMessage(MessageType messageType)
        => messageType
        switch
        {
            MessageType.Empty => "data is empty",
            MessageType.DataNotExists => "Data does Not Exists",
            MessageType.NotPermission => "you can Not Permission",

            _ => "",
        };

}
