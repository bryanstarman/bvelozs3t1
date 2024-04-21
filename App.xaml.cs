namespace bvelozs2t1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.login("a","b"));
        }
    }
}