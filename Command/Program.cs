
using Command.Classes.Service;

var runCommand = new Command.Classes.Service.RunCommand();
runCommand.ExecuteCommand(new InsertAccountCommand(new Command.Classes.Domin.Account() { Id = 1, Type = "1", Balance = 0 }));
runCommand.ExecuteCommand(new UpdateLastBalanceAccountCommand(new Command.Classes.Domin.Account() { Id = 1, Type = "1", Balance =200 }));



runCommand.Undo();
