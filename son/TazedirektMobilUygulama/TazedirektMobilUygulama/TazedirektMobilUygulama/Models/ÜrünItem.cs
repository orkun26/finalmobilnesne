using System;
using System.Collections.Generic;
using System.Text;

namespace TazedirektMobilUygulama.Models
{
    public class ÜrünItem
    {
        private string image;

        public string ImageSource
        {
            get { return image; }
            set { image = value; }
        }
        private string ürünİsmi;

        public string Ürünİsmi
        {
            get { return ürünİsmi; }
            set { ürünİsmi = value; }
        }
        private string satıcı;

        public string Satıcı
        {
            get { return satıcı; }
            set { satıcı = value; }
        }
        private string ürünFiyat;
        public string ÜrünFiyat
        {
            get { return ürünFiyat; }
            set { ürünFiyat = value; }
        }

    }
}
