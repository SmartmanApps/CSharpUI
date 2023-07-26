using Microsoft.Maui.Controls;
namespace CSharpUI;
public class MainPage : ContentPage
{
IColours Colours=new Colours();
IViewFactory ViewFactory;
public MainPage() {
    ViewFactory=new ViewFactory(Colours);
    Content=ViewFactory.NewLabel("Our ViewFactory-generated Label!");
	}
}