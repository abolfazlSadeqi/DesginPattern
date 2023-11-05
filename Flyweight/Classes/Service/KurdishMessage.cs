using Flyweight.Classes.Domin;
using Flyweight.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes.Service;

public class KurdishMessage : ICustomMessage
{

    public string GetMessage(MessageType messageType)
        => messageType
        switch
        {
            MessageType.Empty => "Daneyên vala ne",
            MessageType.DataNotExists => "Dane tune",
            MessageType.NotPermission => "Destûra we tune",

            _ => "",
        };

}
