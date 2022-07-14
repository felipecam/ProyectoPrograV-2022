using ProyectoPrograV_2022.ViewModels;
using ProyectoPrograV_2022.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProyectoPrograV_2022
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
