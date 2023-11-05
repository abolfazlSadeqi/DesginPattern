using Observer.Classes.Domin;
using Observer.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classes.Service;

public class CustomerAgentObserver : IObserver
{
    private readonly CustomerAgentModel _CustomerModel;
    public CustomerAgentObserver(CustomerAgentModel CustomerModel, ISubject subject)
    {
        _CustomerModel = CustomerModel;
        subject.Add(this);
    }
    public void Update(ProductModel ProductModel)
    {
        SmsServices smsServices = new SmsServices();
        smsServices.Send(_CustomerModel.PhoneNumber, $"Hello,{_CustomerModel.Name} your Product ('{ProductModel.Name}')  requested, now exist");
    }

}
