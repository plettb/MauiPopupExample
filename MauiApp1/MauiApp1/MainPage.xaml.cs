using CommunityToolkit.Maui.Views;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        CounterLabel.Text = $"Current count: {count}";

        SemanticScreenReader.Announce(CounterLabel.Text);
    }

    private async void Popup_Clicked(object sender, EventArgs e)
    {
        var popup = new PopupPage();
        await this.ShowPopupAsync(popup);

        await this.DisplayAlert("Done", "Done with the popup", "Cancel"); // This is just here to demonstrate when the popup is done.
    }
}

