﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba_1.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laba_1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        bool loaded = false;
        public ProfilePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (loaded == false)
            {
                DisplayStack.Show(lbNavStack);
                loaded = true;
            }
        }

        async private void btnToBooksPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BooksPage());
        }
    }
}