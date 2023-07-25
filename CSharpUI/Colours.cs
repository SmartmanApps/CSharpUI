using Microsoft.Maui.Graphics;
using System.ComponentModel;
namespace CSharpUI;
public class Colours :INotifyPropertyChanged, IColours
{
public event PropertyChangedEventHandler PropertyChanged;
#region Background
private Color _Background=Color.FromArgb("#FF000000");
public Color Background
{
get {return _Background;}
set {
    if (_Background.ToArgbHex().ToString()!=value.ToArgbHex().ToString()) {
        _Background=value;
        PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Background)));
        }
    }
}
#endregion
#region Foreground
private Color _Foreground=Color.FromArgb("#FF00CC00");
public Color Foreground
{
get {return _Foreground;}
set {
    if (_Foreground.ToArgbHex().ToString()!=value.ToArgbHex().ToString()) {
        _Foreground=value;
        PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Foreground)));
        }
    }
}
#endregion
}