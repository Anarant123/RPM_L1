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

namespace Laba_1
{
    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            ICollection<ResourceDictionary> mergedDictionaries = App.Current.Resources.MergedDictionaries;
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new LightTheme());

            InitializeComponent();
            pickerRole.SelectedIndex = 0;
        }

        async private void btnExit_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Вы действительно хотите выйти?", "Все незавершенные действия не сохраняться", "Да", "Нет");
            if (result)
                Thread.CurrentThread.Abort();
        }

        private void btnRegistration_Clicked(object sender, EventArgs e)
        {
            if(tbLogin.Text != "" && tbAddress.Text != "" && tbEmail.Text != "" && tbPhone.Text != "" && pickerRole.SelectedItem != null)
            {
                if (tbPassword1.Text == null || tbPassword1.Text.Length < 8)
                {
                    DisplayAlert("Ошибка!", "Длина пароля должна быть больше 8", "ОK");
                    return;
                }
                if(tbPassword1.Text == tbPassword2.Text)
                {
                    string role = pickerRole.Items[pickerRole.SelectedIndex];
                    DisplayAlert("Регистрация прошла успешно!", $"Вы зарегистрировались как {role}", "ОK");
                }
                else
                {
                    DisplayAlert("Ошибка!", "Пароли должны совпадать", "ОK");
                }
            }
            else
            {
                DisplayAlert("Ошибка!", "Для успешной регистрации заполните все поля", "ОK");
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
