

///ConcretePrototype

public partial class Setting : ISetting
{

    public long GetPagesize()
        => Pagesize;
    public Setting Clone()
     =>
       new Setting { Title = this.Title, Pagesize = this.Pagesize };
}
