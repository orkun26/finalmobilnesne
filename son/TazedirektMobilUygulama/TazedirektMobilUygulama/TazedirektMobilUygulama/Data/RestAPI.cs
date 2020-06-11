using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using Xamarin.Forms;
using System.ComponentModel;
using TazedirektMobilUygulama.Models;

namespace TazeDirekt1.Data
{
    public class RestAPI
    {
        HttpClient client;
        HttpResponseMessage response;
        public List<Product> Products;
        public List<Category> Categories;
        public List<ImageModel> ImageModels;

        public RestAPI()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://tazedirektsonapi.azurewebsites.net")

            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        public List<Product> GetProducts()
        {
            HttpResponseMessage response = client.GetAsync("api/products").Result;
            if (response.IsSuccessStatusCode)
            {
                var items = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                Products = items as List<Product>;
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Hata!", "Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase, "Tamam");

            }
            foreach (var item in Products)
            {
                foreach (var item2 in ImageModels)
                {
                    if (item2.ProductId == item.Id)
                    {
                        item.ImageUrl = item2.Url;
                        break;
                    }
                }
            }
            return Products;
        }



        public class ImageModel
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string Name { get; set; }
            public int ProductId { get; set; }
            public Product Product { get; set; }
        }

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IList<Product> Products { get; set; } = new List<Product>();

        }
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
          
            public double Cost { get; set; }
            public double PreviousCost { get; set; }
            public int CategoryId { get; set; }
            public string Url { get; set; }
            public int NumberInStock { get; set; }
            public string Info { get; set; }
            public double KargoFiyatı { get; set; }

            public Category Category { get; set; }



            public IList<ImageModel> Images { get; set; } = new List<ImageModel>();
            public string ImageUrl;
        }
       
    }
}