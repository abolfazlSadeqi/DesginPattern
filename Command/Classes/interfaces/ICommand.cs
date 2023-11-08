

using Command.Classes.Domin;

namespace Command.Classes.interfaces;
//Command
public interface ICommand
{
    void Execute();
    void undo();


}

