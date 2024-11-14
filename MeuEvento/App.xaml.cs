namespace MeuEvento
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            //  MainPage = new NavigationPage(new Views.StartPage());
              MainPage = new NavigationPage(new Views.CadastroEvento());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
