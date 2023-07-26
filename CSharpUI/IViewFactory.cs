using Microsoft.Maui.Controls;

namespace CSharpUI
    {
    public interface IViewFactory
        {
        Label NewLabel(string text = "");
        }
    }