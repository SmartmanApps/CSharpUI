using Microsoft.Maui.Controls;
using System.ComponentModel;
using System.Windows.Input;
namespace CSharpUI;
internal class MainPageViewModel : INotifyPropertyChanged
{
int Count=0;
public ICommand ButtonClickedCommand=>new Command(Button_Clicked);
#region events
public event PropertyChangedEventHandler PropertyChanged;
#endregion
#region properties
private string _ClickResultsText="Button has been clicked 0 times";
public string ClickResultsText
{
get {return _ClickResultsText;}
set {
    if (_ClickResultsText!=value) {
        _ClickResultsText=value;
        PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(ClickResultsText)));
        }
    }
}
#endregion
#region methods
void Button_Clicked()
{
Count++;
if (Count>1) {
    ClickResultsText=$"Button has been clicked {Count} times";
} else {
    ClickResultsText=$"Button has been clicked 1 time";
    }
}
#endregion
}
