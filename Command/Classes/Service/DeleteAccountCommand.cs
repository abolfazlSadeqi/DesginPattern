using Command.Classes.Domin;
using Command.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Classes.Service;


public class DeleteAccountCommand : ICommand
{
    private readonly Account _Account;
    public DeleteAccountCommand(Account account)
    {
        _Account = account;
    }

    public void Execute()
    {
        //do (delete Account to DB)
    }

    public void undo()
    {
        //do (insert Account to DB)
    }



}