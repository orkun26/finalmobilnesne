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
    public partial class Ürünlerimiz : ContentPage
    {
        ÜrünModelÜrünlerimiz ÜrünModelÜrünlerimiz;

        public Ürünlerimiz()
        {
            InitializeComponent();
            ÜrünModelÜrünlerimiz = new ÜrünModelÜrünlerimiz(this);
            BindingContext = ÜrünModelÜrünlerimiz;

        }
    }
}