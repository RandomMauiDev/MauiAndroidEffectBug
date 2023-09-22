namespace MauiAndroidEffectBug
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            Routing.RegisterRoute(nameof(Page2), typeof(Page2));
        }
    }
}