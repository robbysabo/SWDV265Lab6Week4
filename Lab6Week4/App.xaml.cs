namespace Lab6Week4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            BindingContext = new Lab6Week4ViewModel();
        }
    }
}
