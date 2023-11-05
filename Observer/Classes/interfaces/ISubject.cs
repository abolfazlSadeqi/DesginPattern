using Observer.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classes.interfaces;

public interface ISubject
{
    void Add(IObserver observer);
    void Remove(IObserver observer);
    void Notify(ProductModel ProductModel);
    void UpdatePrice(ProductModel _ProductModel);
}

