using Microsoft.Maui.Controls;
namespace CSharpUI;
public class ViewFactory :IViewFactory
{
IColours Colours;
#region constructor
public ViewFactory(IColours colours) {
    Colours=colours;
    }
#endregion
#region methods
#region NewLabel
public Label NewLabel(string text = "")
{
Label newLabel=new Label();
    if (text.Length>0) {newLabel.Text=text;}
    newLabel.SetBinding(Label.TextColorProperty,new Binding(nameof(Colours.Foreground),source: Colours));
    newLabel.SetBinding(Label.BackgroundColorProperty,new Binding(nameof(Colours.Background),source: Colours));
    return newLabel;
    }
#endregion
#endregion
}
