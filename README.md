# MauiPopupExample
A trivial app trying to get a simple popup working

Steps taken to produce this example:
1. Clean app from the Maui template in VS 17.2.0 Preview 5.0
2. Add NuGets:
  - CommunityToolkit.Maui
3. Add the necessary lines to the app builder
  - .UseMauiCommunityToolkit()
4. Add a Popup page (see PopupPage)
  - consider setting `CanBeDismissedByTappingOutsideOfPopup="False"`
  - consider adding a "Close" button
5. Add a button to MainPage:
  - `<Button Text="Popup" Clicked="Popup_Clicked" />`
6. Add the event handler:
```
    private async void Popup_Clicked(object sender, EventArgs e)
    {
        var popup = new PopupPage();
        await this.ShowPopupAsync(popup);
    }
```

