using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Laba_1.Services
{
    public static class DisplayStack
    {
        public static void Show(Label label)
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            label.Text = "";
            foreach (Page p in navPage.Navigation.NavigationStack)
            {
                label.Text += p.Title + "\n";
            }
        }
    }
}
