using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Laba_1.Themes;
using Laba_1.Models;
using Laba_1.Views;
using Laba_1.Services;

namespace Laba_1
{
    
    public partial class MainPage : ContentPage
    {
        bool loaded = false;
        public MainPage()
        {
            ICollection<ResourceDictionary> mergedDictionaries = App.Current.Resources.MergedDictionaries;
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new LightTheme());

            InitializeComponent();

            pickerRole.SelectedIndex = 0;
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

        async private void btnExit_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Вы действительно хотите выйти?", "Все незавершенные действия не сохраняться", "Да", "Нет");
            if (result)
                Thread.CurrentThread.Abort();
        }

        async private void btnRegistration_Clicked(object sender, EventArgs e)
        {
            if(tbLogin.Text != null && tbAddress.Text != null && tbEmail.Text != null && tbPhone.Text != null && pickerRole.SelectedItem != null)
            {
                if (tbPassword1.Text == null || tbPassword1.Text.Length < 8)
                {
                    await DisplayAlert("Ошибка!", "Длина пароля должна быть больше 8", "ОK");
                    return;
                }
                if(tbPassword1.Text == tbPassword2.Text)
                {
                    UserNow.Login = tbLogin.Text;
                    UserNow.Birthday = dpBirthday.Date;
                    UserNow.Phone = tbPhone.Text;
                    UserNow.Email = tbEmail.Text;
                    UserNow.Address = tbAddress.Text;
                    UserNow.Role = pickerRole.Items[pickerRole.SelectedIndex];
                    UserNow.Password = tbPassword1.Text;
                    string role = pickerRole.Items[pickerRole.SelectedIndex];
                    await DisplayAlert("Регистрация прошла успешно!", $"Вы зарегистрировались как {role}", "ОK");
                    switch (pickerRole.SelectedIndex)
                    {
                        case 0:
                            await Navigation.PushAsync(new ProfilePage());
                            break;
                        case 1:
                            await Navigation.PushAsync(new LibrarianBooksPage());
                            break;
                        case 2:
                            await Navigation.PushAsync(new AdminPage());
                            break;
                    }

                }
                else
                {
                    await DisplayAlert("Ошибка!", "Пароли должны совпадать", "ОK");
                }
            }
            else
            {
                await DisplayAlert("Ошибка!", "Для успешной регистрации заполните все поля", "ОK");
            }
        }

        async private void btnTheme_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Тема", "Какую тему приложения установить", "Тёмная", "Стветлая");

            ICollection<ResourceDictionary> mergedDictionaries = App.Current.Resources.MergedDictionaries;

            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();

                if (!result)
                {
                    mergedDictionaries.Add(new LightTheme());
                }
                else if(result)
                {
                    mergedDictionaries.Add(new DarkTheme());
                }
            }

          
        }
    }
}
