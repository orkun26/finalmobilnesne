using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TazedirektMobilUygulama.ViewModels;
using Xamarin.Forms;


namespace TazedirektMobilUygulama.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Üreticilerimiz : ContentPage
    {
        ÜrünModelUreticilerimiz1 ÜrünModelUreticilerimiz1;

        public Üreticilerimiz()
        {
            InitializeComponent();
            ÜrünModelUreticilerimiz1 = new ÜrünModelUreticilerimiz1(this);
            BindingContext = ÜrünModelUreticilerimiz1;

        }
    }
}