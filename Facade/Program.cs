using Facade.Classes.interfaces;
using Facade.Classes.Service;

//without Facade

IStackProductServiceArchive _StackProductServiceArchive = new StackProductServiceArchive();
IStackProductService _StackProductService = new StackProductService();

var StackProduct = _StackProductServiceArchive.GetProduct();
StackProduct.AddRange(_StackProductService.GetProduct());




//with Facade
ReportFacade reportFacade = new ReportFacade();

var _list = reportFacade.GetProduct();
Console.ReadLine();