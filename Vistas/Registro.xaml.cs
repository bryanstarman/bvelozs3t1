namespace bvelozs2t1.Vistas;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void btnregistrar_Clicked(object sender, EventArgs e)
    {
		string usuario=txtUsuario.Text;
		string clave=txtClave.Text;
		Navigation.PushAsync(new login(usuario, clave));
    }
}