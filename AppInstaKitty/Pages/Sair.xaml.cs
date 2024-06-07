namespace AppInstaKitty.Pages;

public partial class Sair : ContentPage
{
	public Sair()
	{
		InitializeComponent();
	}

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new LoginPage());
    }
}