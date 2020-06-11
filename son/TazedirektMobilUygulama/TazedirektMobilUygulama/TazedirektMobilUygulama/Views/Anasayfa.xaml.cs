using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazedirektMobilUygulama.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TazedirektMobilUygulama.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        ÜrünModel ÜrünModel;

        public Anasayfa()
        {
            InitializeComponent();
            List<string> CarouselItems = new List<string>()
            {

                "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/banner/main_page_slider/10438/12472-banner_yumurta-7a21a3.jpg",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/banner/main_page_slider/10526/12560-pizza-fd4262.jpg",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/banner/main_page_slider/10460/12494-mayis_banner_temizlik-d71ec1.jpg",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/banner/main_page_slider/10430/12464-mayis_banner_zinde_kal-cc765b.jpg",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/banner/main_page_slider/10475/12509-mayis_banner_yogurt-c65470.jpg",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/banner/main_page_slider/10298/12332-nisan_banner_ramazan-529d03.jpg",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/banner/main_page_slider/10405/12439-mayis_banner_emsal-be5d2c.jpg",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/banner/main_page_slider/9866/11900-korona_1-87f65e.jpg"
            };
            FirsatÜrünleriCarousel.ItemsSource = CarouselItems;

            ÜrünModel = new ÜrünModel(this);
            BindingContext = ÜrünModel;









        }




    }
}