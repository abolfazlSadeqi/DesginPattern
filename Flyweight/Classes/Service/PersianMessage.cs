using Flyweight.Classes.Domin;
using Flyweight.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes.Service;

public class PersianMessage : ICustomMessage
{

    public string GetMessage(MessageType messageType)
        => messageType
        switch
        {
            MessageType.Empty => "دیتا ندارد",
            MessageType.DataNotExists => "دیتا وجود ندارد",
            MessageType.NotPermission => "دسترسی وجود ندارد",

            _ => "",
        };

}
