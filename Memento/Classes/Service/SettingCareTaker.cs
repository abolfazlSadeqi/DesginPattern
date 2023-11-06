using Memento.Classes.Domin;
using Memento.Classes.interfaces;

namespace Memento.Classes.Service;

//Caretaker
public class SettingCareTaker: ISettingCareTakerBase
{
    private List<Settings> _listSetting = new List<Settings>();

    public void Save(Settings _Setting)
       => _listSetting.Add(_Setting);


    public Settings GetLast()
        => _listSetting.Last();
   
}