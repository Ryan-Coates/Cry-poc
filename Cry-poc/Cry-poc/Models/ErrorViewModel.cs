using System;
using System.Collections.Generic;

namespace Cry_poc.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class MapsModel
    {
        public List<MapPoint> Points { get; set; }
        public string MapPointsJSON { get; set; }

        public string SearchString { get; set; }

        public List<Recomendation> Recomendations { get; set; }

        public List<Promotion> Promotions { get; set; }
    }

    public class MapPoint
    {
        //"Id": 1, "PlaceName": "Zaghouan", "GeoLong": "36.401081", "GeoLat": "10.16596"
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public string GeoLong { get; set; }
        public string GeoLat { get; set; }

        public string Rating { get; set; }
        public string Distance { get; set; }
        public string Offer { get; set; }

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
}