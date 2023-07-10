using Iterator.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Classes.Service.Implementation;

/// <summary>
/// reference: https://refactoring.guru/design-patterns/bridge/csharp/example
/// </summary>
// The Implementation defines the interface for all implementation classes.
// It doesn't have to match the Abstraction's interface. In fact, the two
// interfaces can be entirely different. Typically the Implementation
// interface provides only primitive operations, while the Abstraction
// defines higher- level operations based on those primitives.
public interface ISave
{
    string Save(Product product);
}
