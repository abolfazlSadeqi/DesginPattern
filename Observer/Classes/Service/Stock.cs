using Observer.Classes.Domin;
using Observer.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classes.Service;

public class Stock : ISubject
{
    public List<IObserver> observers = new List<IObserver>();
    public ProductModel _ProductModel { get; set; }


    public Stock(ProductModel ProductModel)
    {
        _ProductModel = ProductModel;
    }

    public void UpdatePrice(ProductModel _ProductModel)
    {
        if (_ProductModel.Price > 100) 
            Notify(_ProductModel);
    }

    public void Add(IObserver subscriber) => observers.Add(subscriber);


    public void Remove(IObserver subscriber) => observers.Remove(subscriber);


    public void Notify(ProductModel ProductModel) => Parallel.ForEach(observers, subscriber => subscriber.Update(ProductModel));


}
