using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Laba_1;
using Logikoz.ThemeBase.Services;

namespace Laba_1
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "AppTheme_Experimental" });

            InitializeComponent();
            MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.Black, BarTextColor = Color.White };
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
