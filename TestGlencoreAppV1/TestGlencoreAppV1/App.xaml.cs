using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestGlencoreAppV1.Services;
using TestGlencoreAppV1.Views;

namespace TestGlencoreAppV1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
