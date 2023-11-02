using ChainOfResponsibility.Classes.Domin;
using ChainOfResponsibility.Classes.interfaces;

namespace ChainOfResponsibility.Classes.Service;


public class CustomerNumberValid : AbstractHandler
{
    public override object Handle(object request)
    {
        CustomerModel vm = (CustomerModel)request;

        if (vm.Number.Length == 10)
            return $"number is not valid";
        return base.Handle(request);
    }
}
