

using Command.Classes.Domin;

namespace Command.Classes.interfaces;

public interface ICommand
{
    void Execute();
    void undo();


}

