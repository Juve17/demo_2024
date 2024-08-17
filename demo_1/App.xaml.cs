using demo_1.Views.Home;
using demo_1.Views.Product;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new VHPrincipal());
            //MainPage =new VPPrincipal();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
