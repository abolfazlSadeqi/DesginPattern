using Facade.Classes.Service;

//with both(cache,database)
ProductServiceProxy productServiceProxy = new ProductServiceProxy();

var _list=productServiceProxy.GetProduct();

//only get data on database
ProductServiceProxy productServiceProxyDataBase = new ProductServiceProxy( Proxy.Classes.Domin.CacheConfiguration.DataBase);

var _listb = productServiceProxyDataBase.GetProduct();

Console.ReadLine();