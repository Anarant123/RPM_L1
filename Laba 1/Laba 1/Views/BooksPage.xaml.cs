using Laba_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laba_1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BooksPage : ContentPage
    {
        bool loaded = false;
        public BooksPage()
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

        async private void btnToBook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookPage());
        }
    }
}