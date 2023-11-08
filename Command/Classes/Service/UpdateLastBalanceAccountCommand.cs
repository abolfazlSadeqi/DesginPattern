using Command.Classes.Domin;
using Command.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Classes.Service;


//Concrete command
public class UpdateLastBalanceAccountCommand : ICommand
{
    private readonly Account _Account;
    public UpdateLastBalanceAccountCommand(Account account)
    {
        _Account = account;
    }

    public void Execute()
    {
        //do (Update Last Balance Account to DB)
    }

    public void undo()
    {
        //do (undo Last Balance Account to DB)
    }



}