using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using TazedirektMobilUygulama.Models;
using Xamarin.Forms;

namespace TazedirektMobilUygulama.ViewModels
{
    public class ÜrünModel : BindableObject
    {
        private Page Page;

        public ÜrünModel(Page mainPage)
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
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/7210713/07210713-1e3434-221x148.jpg",

                    Ürünİsmi = string.Format("Organik medjoul 200 g", i),
                    Satıcı = string.Format("Sunny Dates", i),
                    ÜrünFiyat = string.Format("30,00 TL", i),


                };


                Items.Add(ürünItem);
            }
            for (int i = 1; i < 2; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/8110133/08110133-70f316-221x148.jpg",

                    Ürünİsmi = string.Format("Zencefilli Kombucha 500 ml", i),
                    Satıcı = string.Format("Kombucha 2200", i),
                    ÜrünFiyat = string.Format("19,95 TL", i),


                };


                Items.Add(ürünItem);
            }
            for (int i = 2; i < 3; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/6088440/06088440-2d2106-221x148.jpg",

                    Ürünİsmi = string.Format("Çiğ Nurlu Badem 250 g ", i),
                    Satıcı = string.Format("Datça Murat Çiftliği ", i),
                    ÜrünFiyat = string.Format("67,50 TL", i),


                };


                Items.Add(ürünItem);
            }
            for (int i = 3; i < 4; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/8110151/08110151-4bdf6a-221x148.jpg",

                    Ürünİsmi = string.Format("Sade Kombucha 330 ml ", i),
                    Satıcı = string.Format("Kombu Culture", i),
                    ÜrünFiyat = string.Format("14,00 TL", i),


                };


                Items.Add(ürünItem);
            }
            for (int i = 4; i < 5; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/06013020/06013020-f3d363-221x148.jpg",

                    Ürünİsmi = string.Format("Tane Kırmızı Biber 30 g ", i),
                    Satıcı = string.Format("Ayfer Kaur", i),
                    ÜrünFiyat = string.Format("29,95 TL", i),


                };

                Items.Add(ürünItem);
            }
            for (int i = 5; i < 6; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/6031150/06031150-43e10e-221x148.jpg",

                    Ürünİsmi = string.Format("Zeytin Sirkesi 500 ml ", i),
                    Satıcı = string.Format("Havrano", i),
                    ÜrünFiyat = string.Format("33,00 TL", i),


                };

                Items.Add(ürünItem);
            }
            for (int i = 6; i < 7; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5020040/05020040-d982fd-221x148.jpg",

                    Ürünİsmi = string.Format("Paça + İlikli Kemik Suyu 480 ml ", i),
                    Satıcı = string.Format("Veg & bones", i),
                    ÜrünFiyat = string.Format("18,90 TL", i),


                };

                Items.Add(ürünItem);
            }

            for (int i = 0; i < 1; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28069000/28069000-bec38b-221x148.jpg",

                    Ürünİsmi2 = string.Format("Deniz Fasulyesi 500 g", i),
                    Satıcı2 = string.Format("Ege'den Size", i),
                    ÜrünFiyat2 = string.Format("9,05 TL", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 1; i < 2; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28380001/28380001-1cfac9-221x148.jpg",

                    Ürünİsmi2 = string.Format("Semizotu 1 Demet 100g", i),
                    Satıcı2 = string.Format("Erdal Arslan Çiftliği", i),
                    ÜrünFiyat2 = string.Format("11,50 TL", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 2; i < 3; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28380000/28380000-d1fda3-221x148.jpg",

                    Ürünİsmi2 = string.Format("Semizotu (Pimpirim) 500 g", i),
                    Satıcı2 = string.Format("Ege'den Size", i),
                    ÜrünFiyat2 = string.Format("6,98 TL", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 3; i < 4; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/11571903/11571903-42aa0f-221x148.jpg",

                    Ürünİsmi2 = string.Format("French Vanilla Dondurma 400 gr", i),
                    Satıcı2 = string.Format("Pandos", i),
                    ÜrünFiyat2 = string.Format("39,90 TL", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 4; i < 5; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/27028255/27028255-77ef9f-221x148.jpg",

                    Ürünİsmi2 = string.Format("Organik Armut 500 g", i),
                    Satıcı2 = string.Format("Mehmet Emin ", i),
                    ÜrünFiyat2 = string.Format("14,95 TL", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 5; i < 6; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28100018/28100018-375fd1-221x148.jpg",

                    Ürünİsmi2 = string.Format("Enginar 3 Adet 500 gr", i),
                    Satıcı2 = string.Format("Si&Ha ", i),
                    ÜrünFiyat2 = string.Format("19,90 TL", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 6; i < 7; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/27210036/27210036-cfcc2e-221x148.jpg",

                    Ürünİsmi2 = string.Format("Organik Kayısı 500 g", i),
                    Satıcı2 = string.Format("Mehmet Emin ", i),
                    ÜrünFiyat2 = string.Format("10,65 TL", i),


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
