using Builder.Classes.Service;
using Iterator.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes.Instance;


public class BaseContentCreator
{
    private readonly IBaseContentBuilder baseContentBuilder;
    public BaseContentCreator(IBaseContentBuilder builder)
    {
        baseContentBuilder = builder;
    }

    public string Build()
    {
        return baseContentBuilder.Build();
    }
}
