using Memento.Classes.Domin;

namespace Memento.Classes.interfaces;

public interface IAppSettingsBase
{
    
    public void Set(Settings Setting);

    public Settings Save();

    public Settings Restore(Settings Setting);
}