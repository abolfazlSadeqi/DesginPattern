using Flyweight.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes.interfaces;

public interface ICustomMessage
{
   
    string GetMessage(MessageType messageType);

}
