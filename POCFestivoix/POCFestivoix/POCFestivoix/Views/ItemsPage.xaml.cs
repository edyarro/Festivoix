using System;
using System.ComponentModel;
using Xamarin.Forms;

using POCFestivoix.Models;
using POCFestivoix.ViewModels;
using Xamarin.Forms.Maps;

namespace POCFestivoix.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            Item item = args.SelectedItem as Item;

            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage { BindingContext = new ItemDetailViewModel() });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}