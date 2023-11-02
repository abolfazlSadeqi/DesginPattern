using ChainOfResponsibility.Classes.Domin;
using ChainOfResponsibility.Classes.interfaces;

namespace ChainOfResponsibility.Classes.Service;


public class CustomerNameValid : AbstractHandler
{
    public override object Handle(object request)
    {
        CustomerModel vm = (CustomerModel)request;

        if (vm.Name.Length < 10)
            return $"Name is not valid";
        return base.Handle(request);
    }
}
