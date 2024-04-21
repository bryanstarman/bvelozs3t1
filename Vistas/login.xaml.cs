namespace bvelozs2t1.Vistas;

public partial class login : ContentPage
{
    String usuario = "a";
    String clave = "b";
    String[] usuarios = ["Bryan", "Starman", "Nani", "Jhony"];
    String[] claves = ["Bryan123", "Starman123", "Nani123", "Jhony123"];
    int validar = 0;
    public login(string usuariol,string clavel)
	{
        InitializeComponent();
        usuario = usuariol;
        clave = clavel;
        
    }

    private void btnIngresar_Clicked(object sender, EventArgs e)
    {

        String usuario2=txtUsuario.Text;
        String clave2=txtClave.Text;
        /*if(usuario==usuario2 && clave==clave2) {
            Navigation.PushAsync(new vElementos(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "Datos incorrectos", "OK");
        }*/
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuario2 && claves[i]==clave2){
                Navigation.PushAsync(new vElementos(usuarios[i]));
                validar = 1;
            }
        }
        if (validar == 0)
        {
            DisplayAlert("Alerta", "Datos incorrectos", "OK");
        }
        

    }
    private void btnRegistrarse_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Registro());

    }
}