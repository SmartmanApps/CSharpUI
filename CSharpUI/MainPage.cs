using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
namespace CSharpUI;
public class MainPage : ContentPage
{
Button CounterButton;
Grid MainGrid=new Grid();
IColours Colours=new Colours();
IViewFactory ViewFactory;
#region constructor
public MainPage() {
    ViewFactory=new ViewFactory(Colours);
    this.SetBinding(ContentPage.BackgroundColorProperty,new Binding(nameof(Colours.Background),source:Colours));
    MainPageViewModel MPVM=new MainPageViewModel();
#region views
#region Buttons
    CounterButton=new Button{
        Text="Click me",
        HorizontalOptions=LayoutOptions.Center,
        VerticalOptions=LayoutOptions.End,
        BackgroundColor=Color.FromArgb("#FF0000CC"),
        };
    CounterButton.SetBinding(Button.CommandProperty,new Binding(nameof(MPVM.ButtonClickedCommand),source:MPVM));
    CounterButton.SetBinding(Button.TextColorProperty,new Binding(nameof(Colours.Foreground),source:Colours));
#endregion
#region Images
    Image dotnetBotImage=new Image{
        Source="dotnet_bot.png",
//        HeightRequest=200,
        HorizontalOptions=LayoutOptions.Center,
        };
#endregion
#region Labels
#region helloWorldLabel
    Label helloWorldLabel=ViewFactory.NewLabel("Hello, World!");
    helloWorldLabel.FontSize=32;
    helloWorldLabel.HorizontalOptions=LayoutOptions.Center;
#endregion
#region clickResultsLabel
    Label clickResultsLabel=ViewFactory.NewLabel();
    clickResultsLabel.HorizontalOptions=LayoutOptions.Center;
    clickResultsLabel.SetBinding(Label.TextProperty,new Binding(nameof(MPVM.ClickResultsText),source:MPVM));
#endregion
#region welcomeLabel
    Label welcomeLabel=ViewFactory.NewLabel("Welcome to .NET Multi-platform App UI... with C# UI!");
    welcomeLabel.FontSize=40;
    welcomeLabel.HorizontalOptions =LayoutOptions.Center;
#endregion
#endregion
#endregion
#region assemble GUI
    BatchBegin();
    MainGrid.AddRowDefinition(new RowDefinition{Height=GridLength.Auto});
    MainGrid.AddRowDefinition(new RowDefinition{Height=new GridLength(1,GridUnitType.Star)});
    MainGrid.AddColumnDefinition(new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)});
    MainGrid.AddColumnDefinition(new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)});
    MainGrid.Add(welcomeLabel,0,0);
    MainGrid.SetColumnSpan(welcomeLabel,2);
    MainGrid.Add(dotnetBotImage,0,1);
    Grid buttonGrid=new Grid();
    buttonGrid.AddRowDefinition(new RowDefinition {Height=new GridLength(1,GridUnitType.Star)});
    buttonGrid.AddRowDefinition(new RowDefinition {Height=new GridLength(1,GridUnitType.Star)});
    buttonGrid.Add(CounterButton,0,0);
    buttonGrid.Add(clickResultsLabel,0,1);
    MainGrid.Add(buttonGrid,1,1);
    Content=MainGrid;
    BatchCommit();
#endregion
	}
#endregion
}