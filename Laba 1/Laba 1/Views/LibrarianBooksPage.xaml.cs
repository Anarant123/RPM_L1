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
    public partial class LibrarianBooksPage : ContentPage
    {
        public LibrarianBooksPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        async private void btnEditBook_Clicked(object sender, EventArgs e)
        {
            AdOrEditBookPage adOrEditBookPage = new AdOrEditBookPage();
            adOrEditBookPage.Title = "Редактирование книги";
            await Navigation.PushAsync(adOrEditBookPage);
        }

        async private void btnDeleteBook_Clicked(object sender, EventArgs e)
        {
            
        }

        async private void AdBook_Clicked(object sender, EventArgs e)
        {
            AdOrEditBookPage adOrEditBookPage = new AdOrEditBookPage();
            adOrEditBookPage.Title = "Добавление книги";
            await Navigation.PushAsync(adOrEditBookPage);
        }
    }
}