using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TazedirektMobilUygulama.Models;

namespace TazedirektMobilUygulama.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Anasayfa, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Anasayfa:
                        MenuPages.Add(id, new NavigationPage(new Anasayfa()));
                        break;
                    case (int)MenuItemType.Ürünlerimiz:
                        MenuPages.Add(id, new NavigationPage(new Ürünlerimiz()));
                        break;
                    case (int)MenuItemType.Üreticilerimiz:
                        MenuPages.Add(id, new NavigationPage(new Üreticilerimiz()));
                        break;
                    case (int)MenuItemType.TazedirektBesiÇiftliği:
                        MenuPages.Add(id, new NavigationPage(new TazedirektBesiÇiftliği()));
                        break;
                    case (int)MenuItemType.TazedirektNedir:
                        MenuPages.Add(id, new NavigationPage(new TazedirektNedir()));
                        break;
                    case (int)MenuItemType.SSS:
                        MenuPages.Add(id, new NavigationPage(new SSS()));
                        break;
                    case (int)MenuItemType.GirişYap:
                        MenuPages.Add(id, new NavigationPage(new GirişYap()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}