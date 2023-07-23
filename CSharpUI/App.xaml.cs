using Microsoft.Maui.Controls;
namespace CSharpUI;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
