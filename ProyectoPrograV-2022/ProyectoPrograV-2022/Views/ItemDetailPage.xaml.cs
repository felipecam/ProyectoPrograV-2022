using ProyectoPrograV_2022.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProyectoPrograV_2022.Views
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