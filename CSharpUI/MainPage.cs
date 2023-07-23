using Microsoft.Maui.Controls;
namespace CSharpUI;
public class MainPage : ContentPage
{
	public MainPage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI in C#!"
				}
			}
		};
	}
}