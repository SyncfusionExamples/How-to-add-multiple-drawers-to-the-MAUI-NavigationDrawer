namespace NavigationDrawer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPrimaryDrawerToggled(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        private void OnSecondaryDrawerToggled(object sender, EventArgs e)
        {
            navigationDrawer.ToggleSecondaryDrawer();
        }
    }
}
