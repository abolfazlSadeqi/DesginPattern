using Memento.Classes.Domin;

namespace Memento.Classes.interfaces;

public interface ISettingCareTakerBase
{

    void Save(Settings _Setting);

    Settings GetLast();
}