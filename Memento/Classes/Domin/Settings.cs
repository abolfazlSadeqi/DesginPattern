namespace Memento.Classes.Domin;

//Memento.
public class Settings
{
    public int _PageSize { get; set; }
    public string _Title { get; set; }
    public string _TableName { get; set; }
    public long _LimitFileSize { get; set; }

    public Settings(int PageSize, string Title, string TableName, long limitFileSize)
        => Set(PageSize, Title, TableName, limitFileSize);

    private void Set(int PageSize, string Title, string TableName, long limitFileSize)
    {
        _PageSize = PageSize;
        _Title = Title;
        _TableName = TableName;
        _LimitFileSize = limitFileSize;
    }
}