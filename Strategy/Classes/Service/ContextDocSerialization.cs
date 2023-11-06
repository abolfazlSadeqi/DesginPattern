using Strategy.Classes.Domin;
using Strategy.Classes.interfaces;

namespace Strategy.Classes.Service;

//Context
public class ContextDocSerialization
{
    private IDocSerialization _IDocSerialization;
    public ContextDocSerialization(IDocSerialization IDocSerialization) 
        => _IDocSerialization = IDocSerialization;

    public void SwitchStrategy(IDocSerialization strategy)
     => _IDocSerialization = strategy;


    public string ProcessingComplete(ProductModel productModel) 
        => _IDocSerialization.Processing(productModel);

}