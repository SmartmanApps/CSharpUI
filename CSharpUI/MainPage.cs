using Microsoft.Maui;
using Microsoft.Maui.Controls;
namespace CSharpUI;
public class MainPage : ContentPage
{
Button CounterButton;
int Count=0;
#region constructor
public MainPage()
{
#region views
#region Buttons
CounterButton=new Button{
    Text="Click me",
    HorizontalOptions=LayoutOptions.Center,
    };
CounterButton.Clicked+=CounterButton_Clicked;
#endregion
#region Images
Image dotnetBotImage=new Image{
    Source="dotnet_bot.png",
    HeightRequest=200,
    HorizontalOptions=LayoutOptions.Center,
    };
#endregion
#region Labels
Label helloWorldLabel=new Label{
    Text="Hello, World!",
    FontSize=32,
    HorizontalOptions=LayoutOptions.Center,
    };
Label welcomeLabel=new Label{
    Text="Welcome to .NET Multi-platform App UI... with C# UI!",
    FontSize=18,
    HorizontalOptions=LayoutOptions.Center,
    };
#endregion
#endregion
#region assemble GUI
BatchBegin();
VerticalStackLayout mainPageStackLayout=new VerticalStackLayout{
    Spacing=25,
    Padding=new Thickness(30,0),
    };
mainPageStackLayout.Add(dotnetBotImage);
mainPageStackLayout.Add(welcomeLabel);
mainPageStackLayout.Add(CounterButton);
ScrollView mainPageScrollView=new ScrollView{Content=mainPageStackLayout};
Content=mainPageScrollView;
BatchCommit();
#endregion
}
#endregion
#region methods
private void CounterButton_Clicked(object sender,System.EventArgs e)
{
Count++;
if (Count==1) {CounterButton.Text="Clicked 1 time";}
else {CounterButton.Text=$"Clicked {Count} times";}
}
#endregion
}