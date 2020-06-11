using System;
using System.Collections.Generic;
using System.Text;

namespace TazedirektMobilUygulama.Models
{
    public enum MenuItemType
    {
        Anasayfa,
        Ürünlerimiz,
        Üreticilerimiz,
        TazedirektBesiÇiftliği,
        TazedirektNedir,
        SSS,
        GirişYap,
       
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
