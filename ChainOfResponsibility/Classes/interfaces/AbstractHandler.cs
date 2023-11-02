using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Classes.interfaces;

public abstract class AbstractHandler : IHandler
{
    private IHandler NextHandler;
    public virtual object Handle(object request) => (NextHandler?.Handle(request));




    public IHandler SetNext(IHandler next)
    {
        NextHandler = next;
        return next;
    }
}


