using Microsoft.Maui.Controls;
namespace CSharpUI;
public class MainPage : ContentPage
{
IColours Colours=new Colours();
public MainPage() {
	Content = new VerticalStackLayout
		{
		Children = {
			new Label { TextColor=Colours.Foreground, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI in C#!"}
			}
		};
	}
}