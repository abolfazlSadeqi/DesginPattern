using Memento.Classes.Domin;
using Memento.Classes.interfaces;

namespace Memento.Classes.Service;

//Originator
public class AppSettings : IAppSettingsBase
{

    public Settings _Setting { get; set; }
    public void Set(Settings Setting)
         => _Setting = Setting;

    public Settings Save()
     => new Settings(_Setting._PageSize, _Setting._Title, _Setting._TableName, _Setting._LimitFileSize);

    public Settings Restore(Settings Setting)
    {
        _Setting = Setting;
        return Setting;
    }
}