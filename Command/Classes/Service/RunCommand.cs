using Command.Classes.Domin;
using Command.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Classes.Service;

//Invoker
public class RunCommand
{
  
    public Stack<ICommand> _commandHistory = new();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commandHistory.Push(command);
    }

    public void Undo()
    {
        var command = _commandHistory.Pop();
         command.undo();
    }
}
