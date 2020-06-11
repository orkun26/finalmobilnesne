using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using TazedirektMobilUygulama.Models;

namespace TazedirektMobilUygulama.ViewModels
{
    public class ÜrünModelÜrünlerimiz : BindableObject
    {
        private Page Page;

        public ÜrünModelÜrünlerimiz(Page mainPage)
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
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28260004/28260004-d31b17-221x148.jpg",

                    Ürünİsmi = string.Format("Maydanoz Demet 250 gr", i),
                    Satıcı = string.Format("Sevgi Bayat Çiftliği", i),
                    ÜrünFiyat = string.Format("3,20 TL", i),


                };


                Items.Add(ürünItem);
            }
            for (int i = 1; i < 2; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28160000/28160000-5e99aa-221x148.jpg",

                    Ürünİsmi = string.Format("Sakız Kabak    500 g", i),
                    Satıcı = string.Format("Erdal Arslan Çiftliği", i),
                    ÜrünFiyat = string.Format("7,80 TL", i),


                };


                Items.Add(ürünItem);
            }
            for (int i = 2; i < 3; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28131000/28131000-753133-221x148.jpg",

                    Ürünİsmi = string.Format("Badem Hıyar    500 g ", i),
                    Satıcı = string.Format("Organicasa ", i),
                    ÜrünFiyat = string.Format("4,90 TL", i),


                };


                Items.Add(ürünItem);
            }
            for (int i = 3; i < 4; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28120006/28120006-ac18e3-221x148.jpg",

                    Ürünİsmi = string.Format("Organik Havuç    1 kg", i),
                    Satıcı = string.Format("Erdal Arslan Çiftliği", i),
                    ÜrünFiyat = string.Format("9,50 TL", i),


                };


                Items.Add(ürünItem);
            }
            for (int i = 4; i < 5; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/27287001/27287001-2a04b8-221x148.jpg",

                    Ürünİsmi = string.Format("Organik Limon 500 g", i),
                    Satıcı = string.Format("Ahmet Okan Çiftliği", i),
                    ÜrünFiyat = string.Format("9,95 TL", i),


                };

                Items.Add(ürünItem);
            }
            for (int i = 5; i < 6; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28345010/28345010-5e5ea7-221x148.jpg",

                    Ürünİsmi = string.Format("Organik Roka 1 demet", i),
                    Satıcı = string.Format("Erdal Arslan Çiftliği", i),
                    ÜrünFiyat = string.Format("3,60 TL", i),


                };

                Items.Add(ürünItem);
            }
            for (int i = 6; i < 7; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/27272016/27272016-d53579-221x148.jpg",

                    Ürünİsmi = string.Format("Organik Yerli Muz 1 kg ", i),
                    Satıcı = string.Format("Reyhan Erdoğan ", i),
                    ÜrünFiyat = string.Format("15,90 TL", i),


                };

                Items.Add(ürünItem);
            }

            for (int i = 0; i < 1; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/25010412/25010412-e8b178-221x148.jpg",

                    Ürünİsmi2 = string.Format("Dana Kıyma    500 g", i),
                    Satıcı2 = string.Format("Tazedirekt Besi ", i),
                    ÜrünFiyat2 = string.Format("32,95 TL", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 1; i < 2; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/25010413/25010413-04c5af-221x148.jpg",

                    Ürünİsmi2 = string.Format("Dana Yağsız Kıyma 500 g", i),
                    Satıcı2 = string.Format("Tazedirekt Besi ", i),
                    ÜrünFiyat2 = string.Format("37,45 TL", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 2; i < 3; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/24010230/24010230-1a26aa-221x148.jpg",

                    Ürünİsmi2 = string.Format("Kuzu Kıyma      500 g", i),
                    Satıcı2 = string.Format("Tazedirekt Besi ", i),
                    ÜrünFiyat2 = string.Format("44,95 TL", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 3; i < 4; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/25010441/25010441-bc513f-221x148.jpg",

                    Ürünİsmi2 = string.Format("Dana Çorbalık İlikli Kemik 900 g", i),
                    Satıcı2 = string.Format("Tazedirekt Besi ", i),
                    ÜrünFiyat2 = string.Format("17,06 TL", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 4; i < 5; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/25030126/25030126-bfb282-221x148.jpg",

                    Ürünİsmi2 = string.Format("Izgara Köfte     500 g", i),
                    Satıcı2 = string.Format("Tazedirekt Besi ", i),
                    ÜrünFiyat2 = string.Format("32,95 TL", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 5; i < 6; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/25010346/25010346-82b69d-221x148.jpg",

                    Ürünİsmi2 = string.Format("Dana Antrikot Burger 500 g", i),
                    Satıcı2 = string.Format("Tazedirekt Besi ", i),
                    ÜrünFiyat2 = string.Format("34,95 TL", i),


                };

                Items2.Add(ürünItem2);
            }
            for (int i = 6; i < 7; i++)
            {
                ÜrünItem2 ürünItem2 = new ÜrünItem2()
                {
                    ImageSource2 = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/24010215/24010215-9365ac-221x148.jpg",

                    Ürünİsmi2 = string.Format("Kuzu Kalem Pirzola 400 g", i),
                    Satıcı2 = string.Format("Tazedirekt", i),
                    ÜrünFiyat2 = string.Format("55,16 TL", i),


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
