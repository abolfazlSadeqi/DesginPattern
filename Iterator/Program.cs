using Iterator.Classes.Instance;
using Iterator.Classes.Service;

IteratorInstace iteratorInstace = new IteratorInstace();
var _result= iteratorInstace.RemoveAdjecentDuplicates(new ProductService().GetProducts());

