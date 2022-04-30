using CommunityToolkit.Maui.Views;

namespace MauiApp1;

public partial class PopupPage : Popup
{
    public PopupPage()
    {
        InitializeComponent();
    }

    private void OK_Clicked(object sender, EventArgs e)
    {
        this.Close();
    }
}