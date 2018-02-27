using Crypoc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypoc
{
    public class MockDataService
    {
        public StoreModel GetStoreModel(StoreModel model)
        {

            populateFilteredModel(model);

            model.GenerateJSON();

            #region todo; this should all be refactored into something but who cares right now?
            model.Promotions = new List<Promotion>();
            model.Promotions.Add(new Promotion
            {
                Id = 1,
                PlaceName = "Better Cafe",
                Description = "20% off all orders over £20 when paying with NANO"
            });
            model.Promotions.Add(new Promotion
            {
                Id = 2,
                PlaceName = "OK Cafe",
                Description = "Free coffee with NANO order over £5"

            });
            model.Promotions.Add(new Promotion
            {
                Id = 3,
                PlaceName = "Good Cafe",
                Description = "15% off if you pay voa Bitcoin & NANO!"
            });
            model.Promotions.Add(new Promotion
            {
                Id = 3,
                PlaceName = "Small Cafe",
                Description = "2 for 1 on all orders via bitcoin"
            });

            model.Recomendations = new List<Recomendation>();
            model.Recomendations.Add(new Recomendation
            {
                Id = 1,
                PlaceName = "Better Cafe",
                Description = "Received five recomendations today"

            });
            model.Recomendations.Add(new Recomendation
            {
                Id = 2,
                PlaceName = "OK Cafe",
                Description = "Your friend Andrew recommends OK Cafe's Bacon Sandwich"

            });
            model.Recomendations.Add(new Recomendation
            {
                Id = 3,
                PlaceName = "Fancy Cafe",
                Description = "Tried and toasted! Get 5% off on us!"

            });
            #endregion

            return model;
        }

        private void populateFilteredModel(StoreModel model)
        {
            model.Stores = new List<Store>();
            model.Stores.Add(new Store
            {
                Id = 1,
                PlaceName = "Chinese palace",
                GeoLong = "54.972842",
                GeoLat = "-1.428277",
                Distance = "12 km",
                Offer = "Promo: 20% off",
                Rating = "4.5/5",
                Theme = ThemesEnum.Food.ToString(),
                Currencies = new List<CurrencyEnum>() { CurrencyEnum.BitCoin, CurrencyEnum.Ripple, CurrencyEnum.Etherium }

            });
            model.Stores.Add(new Store
            {
                Id = 2,
                PlaceName = "King kebab",
                GeoLong = "54.972823",
                GeoLat = "-1.458364",
                Distance = "1 km",
                Offer = "None",
                Rating = "4.1/5",
                Theme = ThemesEnum.Food.ToString(),
                Currencies = new List<CurrencyEnum>() { CurrencyEnum.BitCoin, CurrencyEnum.Etherium }
            });
            model.Stores.Add(new Store
            {
                Id = 3,
                PlaceName = "Pizza Pizza!",
                GeoLong = "54.972949",
                GeoLat = "-1.408400",
                Distance = "2 km",
                Offer = "Promo: Buy one get one free",
                Rating = "3.5/5",
                Theme = ThemesEnum.Vaping.ToString(),
                Currencies = new List<CurrencyEnum>() { CurrencyEnum.BitCoin }
            });

            //todo: obvs this isn't the best way to filter we can do it on the data capture
            if (model.Theme == ThemesEnum.All)
            {
                model.Stores = model.Stores.Where(x => x.Theme == model.Theme.ToString()).ToList();
            }
            if (model.Currency == CurrencyEnum.All)
            {
                model.Stores = model.Stores.Where(x => x.Currencies.Contains(model.Currency)).ToList();
            }

        }
    }
}
