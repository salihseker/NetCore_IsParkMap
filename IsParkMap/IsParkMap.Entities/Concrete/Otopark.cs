using IsParkMap.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsParkMap.Entities.Concrete
{
    public class Otopark : ITable
    {
        public int _id { get; set; }
        public int ParkID { get; set; }
        public string ParkAdi { get; set; }
        public int LokasyonID { get; set; }
        public int LokasyonKodu { get; set; }
        public string LokasyonAdi { get; set; }
        public int ParkTipiID { get; set; }
        public string ParkTipi { get; set; }
        public int ParkKapasitesi { get; set; }
        public string CalismaSaatleri { get; set; }
        public int BolgeID { get; set; }
        public string Bolge { get; set; }
        public int AltBolgeID { get; set; }
        public string AltBolge { get; set; }
        public int IlceID { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public string EnlemBoylam { get; set; }
        public string PolygonVerisi { get; set; }
        public float Boylam { get; set; }
        public float Enlem { get; set; }
        public float AylikAbonelikUcreti { get; set; }
        public int UcretsizParklanmaSuresidakika { get; set; }
        public string Tarifesi { get; set; }
        public int ParkEtDevamEtNoktasi { get; set; }
    }

}
