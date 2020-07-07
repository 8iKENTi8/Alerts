using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DisplayAlerts
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Pop up", "Привет от Xamarin", "OK");
        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
          bool res =  await DisplayAlert("Выбор действий", "Перекрасть фон в желтый", "Да", "Нет");

            if (res)
                StackLayout1.BackgroundColor = Color.FromHex("fff176");
            else
                await DisplayAlert("", "Действие отменено", "ок");
        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            string res = await DisplayActionSheet("Изменение цвета текста", "Отмена", null ,
                "Красный", "Синий", "Зеленый", "Желтый");

            switch (res)
            {
                case "Красный":
                    Editor1.TextColor = Color.FromHex("f44336");
                        break;
                case "Синий":
                    Editor1.TextColor = Color.FromHex("26c6da");
                        break;
                case "Зеленый":
                    Editor1.TextColor = Color.GreenYellow;
                        break;
                case "Желтый":
                    Editor1.TextColor = Color.FromHex("fff176");
                        break;
            }
        }
    }
}
