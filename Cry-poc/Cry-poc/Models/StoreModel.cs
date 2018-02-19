using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypoc.Models
{
    public class StoreModel
    {
        public List<Store> Stores { get; set; }
        public string StoresJSON { get; set; }

        public string SearchString { get; set; }

        public List<Recomendation> Recomendations { get; set; }

        public List<Promotion> Promotions { get; set; }

        public SelectList Currencies { get; set; }
        public SelectList Themes { get; set; }

        public void GenerateJSON()
        {
            StoresJSON = Newtonsoft.Json.JsonConvert.SerializeObject(Stores);
        }
    }

    public class Store
    {        
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public string GeoLong { get; set; }
        public string GeoLat { get; set; }

        public string Rating { get; set; }
        public string Distance { get; set; }
        public string Offer { get; set; }
        public List<CurrencyEnum> Currencies { get; set; }
        public string Theme { get; set; }

    }

    public class Recomendation
    {
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public string Description { get; set; }
    }
    public class Promotion
    {
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public string Description { get; set; }
    }

    public enum CurrencyEnum
    {
        All = 0,
        BitCoin = 1,
        Ripple = 2,
        Etherium = 3
    }
    public enum ThemesEnum
    {
        All = 0,
        Food = 1,
        Vaping = 2

    }
}
