using ChainOfResponsibility.Classes.Domin;
using ChainOfResponsibility.Classes.Service;

CustomerModel Customervm = new CustomerModel() { Number = "123", Name = "test4", Address = "tehran,shariati,12", Account = "123" };


CustomerNameValid _CustomerNameValidHandler = new CustomerNameValid();
CustomerNumberValid _CustomerNumberValidHandler = new CustomerNumberValid();
CustomerAddressValid _CustomerAddressValidHandler = new CustomerAddressValid();


_CustomerNameValidHandler.SetNext(_CustomerNumberValidHandler).SetNext(_CustomerAddressValidHandler);

var finalMessage = _CustomerNameValidHandler.Handle(Customervm);
