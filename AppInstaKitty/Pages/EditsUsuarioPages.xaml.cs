using AppInstaKitty.Model;

namespace AppInstaKitty.Pages;

public partial class EditsUsuarioPage : ContentPage
{
    Usuario _usuario;

    public EditsUsuarioPage()
    {
        _usuario = new Usuario();
        this.BindingContext = _usuario;

        InitializeComponent();
    }

    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_usuario.Email) && string.IsNullOrEmpty(_usuario.Senha) && string.IsNullOrEmpty(_usuario.Nome))
        {
            await DisplayAlert("Erro", "Preencha todas as informa��es", "Fechar");
            return;
        }
        var cadastro = await App.BancoDados.UserDataTable.SalvarUsuario(_usuario);

        if (cadastro > 0)
        {
            await DisplayAlert("Sucesso", "Usu�rio cadastrado com sucesso", "Fechar");
            await Navigation.PopAsync();
        }
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }


}