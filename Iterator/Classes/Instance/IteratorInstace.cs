using Iterator.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Classes.Instance;

public class IteratorInstace
{
    public IEnumerable<Product> RemoveAdjecentDuplicates(IEnumerable<Product> Product)
    {
        using (var iterator = Product.GetEnumerator())
        {
            if (!iterator.MoveNext()) yield break;
            var current = iterator.Current;
            yield return current;
            while (iterator.MoveNext())
            {
                if (iterator.Current.Code.Equals(current.Code)) continue;
                current = iterator.Current;
                yield return current;
            }
        }
    }
}
