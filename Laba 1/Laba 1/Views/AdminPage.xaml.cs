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
    public partial class AdminPage : ContentPage
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        async private void btnShowStats_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StatisticsPage());
        }

        async private void btnEditUser_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditingUsersPage());
        }
    }
}