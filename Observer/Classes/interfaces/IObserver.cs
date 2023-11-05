using Observer.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classes.interfaces;

public interface IObserver
{

    void Update(ProductModel ProductModel);
}