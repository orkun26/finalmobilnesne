using TazedirektMobilUygulama.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TazedirektMobilUygulama.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Anasayfa, Title="AnaSayfa" },
                new HomeMenuItem {Id = MenuItemType.Ürünlerimiz, Title="Ürünlerimiz" },
                new HomeMenuItem {Id = MenuItemType.Üreticilerimiz, Title="Üreticilerimiz" },
                new HomeMenuItem {Id = MenuItemType.TazedirektBesiÇiftliği, Title="Tazedirekt Besi Çiftliği" },
                new HomeMenuItem {Id = MenuItemType.TazedirektNedir, Title="Tazedirekt nedir?" },
                new HomeMenuItem {Id = MenuItemType.SSS, Title="SSS & İletişim" },
                new HomeMenuItem {Id = MenuItemType.GirişYap, Title="Giriş Yap / Üye Ol" },
           
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}