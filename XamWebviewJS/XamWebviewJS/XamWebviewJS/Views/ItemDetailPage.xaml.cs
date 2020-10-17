using System.ComponentModel;
using Xamarin.Forms;
using XamWebviewJS.ViewModels;

namespace XamWebviewJS.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}