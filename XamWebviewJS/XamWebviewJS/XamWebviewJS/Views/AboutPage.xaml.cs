using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamWebviewJS.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            webView.Source = "https://www.google.com";
           
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Task.Delay(500);

                await webView.EvaluateJavaScriptAsync("document.querySelectorAll('#gb-main header')[0].innerHTML = '<h2>XAMARIN</h2>'; ");
                await webView.EvaluateJavaScriptAsync("document.querySelectorAll('#gb-main header')[0].style.padding = '10px'; ");
                await webView.EvaluateJavaScriptAsync("document.querySelectorAll('#gb-main header')[0].style.color = 'red'; ");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}