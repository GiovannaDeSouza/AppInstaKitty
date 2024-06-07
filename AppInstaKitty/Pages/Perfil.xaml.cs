using AppInstaKitty.Model;

namespace AppInstaKitty.Pages;

public partial class Perfil : ContentPage
{
    private Usuario _usuario;
	public Perfil()
	{
		InitializeComponent();

        _usuario = App.Usuario;

        this.BindingContext = _usuario;

        ftPerfil.Clicked += async (sender, e) =>
        {
            if (MediaPicker.IsCaptureSupported)
            {
                var file = await MediaPicker.PickPhotoAsync();
                if (file != null)
                {
                    var filePath = file.FullPath;

                    ftPerfil.Source = ImageSource.FromFile(filePath);

                    _usuario.Foto = filePath;
                    await App.BancoDados.UserDataTable.SalvarUsuario(_usuario);

                }
            }
        };
    }

    

     



    private async void BtnHome_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
}
