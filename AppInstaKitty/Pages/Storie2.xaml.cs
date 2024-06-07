using System.Text.RegularExpressions;

namespace AppInstaKitty.Pages;

public partial class Storie2 : ContentPage
{

    private int currentGroupIndex = 0;
    private List<List<ContentView>> groups;
    private bool _isIcon5 = true;

    public Storie2()
    {
        InitializeComponent();
        groups = new List<List<ContentView>>
        {
                new List<ContentView> { Storie1, user1 },
                new List<ContentView> { Stori2, user2 },
                new List<ContentView> { Storie3, user3 },
                new List<ContentView> { Storie4, user4 },
                new List<ContentView> { Storie5, user5 },
                new List<ContentView> { Storie6, user6 }
        };

        ShowCurrentGroup();

        MessagingCenter.Subscribe<MainPage>(this, "OpenContentView", (sender) =>
        {
            Stori2.IsVisible = true;
        });
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        MessagingCenter.Unsubscribe<MainPage>(this, "OpenContentView");
    }



    private async void btnHome_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new HomePage());

    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

        if (_isIcon5)
        {
            iconImage5.Source = "like.svg";
        }
        else
        {
            iconImage5.Source = "like2.svg";
        }

         _isIcon5 = !_isIcon5;



    }

    private void enviar_Clicked(object sender, EventArgs e)
    {
        coments.Text = string.Empty;

    }

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {

        HideCurrentGroup();

        currentGroupIndex = (currentGroupIndex - 1 + groups.Count) % groups.Count;

        ShowCurrentGroup();
    }

    private void btnPassar_Clicked(object sender, EventArgs e)
    {

        HideCurrentGroup();

        currentGroupIndex = (currentGroupIndex + 1) % groups.Count;

        ShowCurrentGroup();

    }

    private void ShowCurrentGroup()
    {
        foreach (var contentView in groups[currentGroupIndex])
        {
            contentView.IsVisible = true;
        }
    }

    private void HideCurrentGroup()
    {
        foreach (var contentView in groups[currentGroupIndex])
        {
            contentView.IsVisible = false;
        }
    }


}