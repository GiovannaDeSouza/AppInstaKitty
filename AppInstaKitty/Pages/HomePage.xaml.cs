
using AppInstaKitty.Model;
namespace AppInstaKitty.Pages;

public partial class HomePage : ContentPage
{
    private Usuario _usuario;
    private bool _isIcon1 = true;
    private bool _isIcon2 = true;
    private bool _isIcon3 = true;

    public HomePage()
	{
		InitializeComponent();

        _usuario = App.Usuario;

        this.BindingContext = _usuario;

    }
    private void OnImageTapped(object sender, EventArgs e)
    {
        if (_isIcon1)
        {
            iconImage.Source = "like.svg";
        }
        else
        {
            iconImage.Source = "like2.svg";
        }

        _isIcon1 = !_isIcon1;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

        if (_isIcon2)
        {
            iconImage2.Source = "like.svg";
        }
        else
        {
            iconImage2.Source = "like2.svg";
        }

        _isIcon2 = !_isIcon2;
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {

        if (_isIcon3)
        {
            iconImage3.Source = "like.svg";
        }
        else
        {
            iconImage3.Source = "like2.svg";
        }

        _isIcon3 = !_isIcon3;

    }

    
    

    private async void BtnHome_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new HomePage());


    }

    private async void btnStorie2_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Storie2());

    }

    private void btnVlt_Clicked(object sender, EventArgs e)
    {
        ShowContent(1);
    }

    private void btnIr_Clicked(object sender, EventArgs e)
    {
        ShowContent(2);
    }

    private void ShowContent(int contentIndex)
    {
        Content1.IsVisible = contentIndex == 1;
        Content2.IsVisible = contentIndex == 2;
    }

    private async void btnStorie2_Clicked_1(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Storie2());

    }

    private async void btnStorie3_Clicked(object sender, EventArgs e)
    {


        await Navigation.PushAsync(new Storie2());

        MessagingCenter.Send(this, "OpenContentView");

    }

    private async void btnStorie4_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Storie2());

        MessagingCenter.Send(this, "OpenContentView");
    }

    private async void btnStorie1_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Storie2());

        MessagingCenter.Send(this, "OpenContentView");

    }

    private async void btnStorie5_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Storie2());

        MessagingCenter.Send(this, "OpenContentView");
    }

    private async void bntStorie6_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Storie2());

        MessagingCenter.Send(this, "OpenContentView");
    }
}