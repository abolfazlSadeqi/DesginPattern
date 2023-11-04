using Command.Classes.Domin;
using Command.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Classes.Service;


public class InsertAccountCommand : ICommand
{
    private readonly Account _Account;
    public InsertAccountCommand(Account account)
    {
        _Account = account;
    }

    public void Execute()
    {
        //do (insert Account to DB)
    }

    public void undo()
    {
        //do (delete Account to DB)
    }


}