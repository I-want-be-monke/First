using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {

        Button button;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
          /*  StackLayout stack = new StackLayout();
            Label label = new Label();
            label.Text = "AAAAAAAAAA";
            label.TextTransform = TextTransform.Uppercase;
            label.FontSize = 25;

            button = new Button();
            button.Text = "click me";
            button.FontSize = 25;
            button.TextColor = Color.Red;
            button.Clicked += buttonclick;


            stack.Children.Add(label);
            stack.Children.Add(button);

            Content = stack;
*/
        }

        private async void ButtonClick(object sender, EventArgs e)
        {
            /*button.Text = "WOW YOU CLIKED ME";
            button.TextColor = Color.Green;*/
            if (string.IsNullOrEmpty(nameField.Text))
                errorText.Text = "Укажте свое имя";
            else if (string.IsNullOrEmpty(emailField.Text))
                errorText.Text = "Укажите свой email";
            else if (string.IsNullOrEmpty(passField.Text))
                errorText.Text = "Создайте пароль";
            else if (!checkField.IsChecked)
                errorText.Text = "Согласитесь на рабство(пожалуйста)";
            else
            {
                errorText.Text = "";
                buttonSend.Text = "Done";
                buttonSend.TextColor = Color.Green;
                await DisplayAlert("Данные из формы", "Все данные получены", "OK");
            }
        }
    }
}
