using ChainOfResponsibility.Classes.Domin;
using ChainOfResponsibility.Classes.interfaces;

namespace ChainOfResponsibility.Classes.Service;


public class CustomerAddressValid : AbstractHandler
{
    public override object Handle(object request)
    {
        CustomerModel vm = (CustomerModel)request;

        if (vm.Address.Split(",").Count() != 3)
            return $"Address is not valid";
        return base.Handle(request);
    }
}
