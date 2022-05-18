using MasterDetailPage.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MasterDetailPage.Views
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