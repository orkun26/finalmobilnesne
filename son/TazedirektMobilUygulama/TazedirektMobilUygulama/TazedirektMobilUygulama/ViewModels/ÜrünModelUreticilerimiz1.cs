using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using TazedirektMobilUygulama.Models;

namespace TazedirektMobilUygulama.ViewModels
{
    class ÜrünModelUreticilerimiz1 : BindableObject
    {
        private Page Page;

        public ÜrünModelUreticilerimiz1(Page mainPage)
        {
            this.Page = mainPage;
            AddItems();

        }


        private void AddItems()
        {
            for (int i = 0; i < 1; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000000282/acetum-a0a006-280x280.jpg",
                    Ürünİsmi = string.Format("Acentum", i),

                };


                Items.Add(ürünItem);
            }
            for (int i = 1; i < 2; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000000128/acquapannalogo-392da4-280x280.jpg",
                    Ürünİsmi = string.Format("Acqua Panna", i),



                };


                Items.Add(ürünItem);
            }
            for (int i = 2; i < 3; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000005449/ahmetokan-9ee0d9-280x280.png",

                    Ürünİsmi = string.Format("Ahmet Okan Çiftliği", i),


                };


                Items.Add(ürünItem);
            }
            for (int i = 3; i < 4; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000000076/alacati-4af683-280x280.jpg",

                    Ürünİsmi = string.Format("Alaçatı Ev", i),


                };


                Items.Add(ürünItem);
            }
            for (int i = 4; i < 5; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000000157/alberto-2579bc-280x280.jpg",

                    Ürünİsmi = string.Format("Alberto Di Centa ", i),


                };

                Items.Add(ürünItem);
            }
            for (int i = 5; i < 6; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000000169/alprologo-9a1044-280x280.jpg",

                    Ürünİsmi = string.Format("Alpro", i),

                };

                Items.Add(ürünItem);
            }
            for (int i = 6; i < 7; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000000172/alt%C4%B1nkilic-991e72-280x280.png",

                    Ürünİsmi = string.Format("Altınkılıç ", i),



                };

                Items.Add(ürünItem);
            }
            for (int i = 0; i < 1; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000005279/bactolaclogo-cecbdf-280x280.jpg",

                    Ürünİsmi2 = string.Format("Bactaloc", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 1; i < 2; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000000218/bagdat-d1d352-280x280.jpg",

                    Ürünİsmi2 = string.Format("Bağdat", i),

                };

                Items2.Add(ürünItem2);
            }
            for (int i = 2; i < 3; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000000218/bagdat-d1d352-280x280.jpg",

                    Ürünİsmi2 = string.Format("Baltalı", i),

                };

                Items2.Add(ürünItem2);
            }
            for (int i = 3; i < 4; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000000148/baltali-f85221-280x280.png",

                    Ürünİsmi2 = string.Format("Beeo", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 4; i < 5; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000000214/beeo-08bef4-280x280.png",

                    Ürünİsmi2 = string.Format("Berva", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 5; i < 6; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000005842/guner-aciksoz-odul-621367-280x280.jpg",

                    Ürünİsmi2 = string.Format("Beşe 1885", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 6; i < 7; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/brand/list/10000000000360/beyoglu.gazoz-375187-280x280.jpg",

                    Ürünİsmi2 = string.Format("Beyoğlu Gazozu", i),


                };

                Items2.Add(ürünItem2);
            }




        }


        private ObservableCollection<ÜrünItem> _items = new ObservableCollection<ÜrünItem>();

        public ObservableCollection<ÜrünItem> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        private ObservableCollection<ÜrünItem2> _items2 = new ObservableCollection<ÜrünItem2>();
        public ObservableCollection<ÜrünItem2> Items2
        {
            get
            {
                return _items2;
            }
            set
            {
                if (_items2 != value)
                {
                    _items2 = value;
                    OnPropertyChanged(nameof(Items2));
                }
            }
        }

        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {
                    Page.DisplayAlert("FlowListView", data + "", "Ok");
                });
            }
        }
    }
}
