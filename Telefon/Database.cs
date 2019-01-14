using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    class Database
    {
        public List<Marka> GetMarka()
        {
            List<Marka> markalar = new List<Marka>();
            markalar.Add(new Marka
            {
                MarkaID=1,
                MarkaAd="Samsung"
            });
            markalar.Add(new Marka
            {
                MarkaID = 2,
                MarkaAd = "Apple"
            });
            markalar.Add(new Marka
            {
                MarkaID = 3,
                MarkaAd = "Huawei"
            });
            return markalar;
        }
        public List<Telefon> GetTelefonlar()
        {
            List<Telefon> telefonlar = new List<Telefon>();
            telefonlar.Add(new Telefon
            {
                TelefonID=1,
                MarkaID=1,
                ModelID=1,
                HafızaBoyutu="32 gb",
                KameraMegapixel="16 mgp"
            });
            telefonlar.Add(new Telefon
            {
                TelefonID = 2,
                MarkaID=1,
                ModelID = 2,
                HafızaBoyutu = "64 gb",
                KameraMegapixel = "32 mgp"
            });
            telefonlar.Add(new Telefon
            {
                TelefonID = 3,
                MarkaID=2,
                ModelID = 3,
                HafızaBoyutu = "128 gb",
                KameraMegapixel = "64 mgp"
            });
            telefonlar.Add(new Telefon
            {
                TelefonID = 4,
                MarkaID = 2,
                ModelID = 4,
                HafızaBoyutu = "16 gb",
                KameraMegapixel = "12 mgp"
            });
            telefonlar.Add(new Telefon
            {
                TelefonID = 5,
                ModelID = 3,
                MarkaID = 3,
                HafızaBoyutu = "32 gb",
                KameraMegapixel = "12 mgp"
            });
            telefonlar.Add(new Telefon
            {
                TelefonID = 6,
                ModelID = 3,
                MarkaID = 3,
                HafızaBoyutu = "256 gb",
                KameraMegapixel = "32 mgp"
            });

            return telefonlar;
        }
        public List<Model> GetModeller()
        {
            List<Model> modeller = new List<Model>();
            modeller.Add(new Model
            {
                ModelID=1,
                ModelAdi = "S7",
                Fiyati=2000,
                UretimYili=DateTime.Parse("01.01.2017")
            });
            modeller.Add(new Model
            {
                ModelID = 2,
                ModelAdi = "S6",
                Fiyati = 1500,
                UretimYili = DateTime.Parse("01.01.2016")
            });
            modeller.Add(new Model
            {
                ModelID = 3,
                ModelAdi = "XS MAX",
                Fiyati = 10000,
                UretimYili = DateTime.Parse("01.01.2018")
            });
            modeller.Add(new Model
            {
                ModelID = 4,
                ModelAdi = "6S",
                Fiyati = 3500,
                UretimYili = DateTime.Parse("01.01.2015")
            });
            modeller.Add(new Model
            {
                ModelID = 5,
                ModelAdi = "4S",
                Fiyati = 1000,
                UretimYili = DateTime.Parse("01.01.2012")
            });
            modeller.Add(new Model
            {
                ModelID = 6,
                ModelAdi = "P20",
                Fiyati = 3500,
                UretimYili = DateTime.Parse("01.01.2018")
            });
            modeller.Add(new Model
            {
                ModelID = 7,
                ModelAdi = "P20 Lite",
                Fiyati = 3900,
                UretimYili = DateTime.Parse("01.01.2017")
            });
            modeller.Add(new Model
            {
                ModelID = 8,
                ModelAdi = "Sallama Model 1.2",
                Fiyati = 2800,
                UretimYili = DateTime.Parse("01.01.2009")
            });
            modeller.Add(new Model
            {
                ModelID = 9,
                ModelAdi = "12.4 C",
                Fiyati = 3600,
                UretimYili = DateTime.Parse("01.01.2014")
            });
            modeller.Add(new Model
            {
                ModelID = 10,
                ModelAdi = "12 BJK",
                Fiyati = 7000,
                UretimYili = DateTime.Parse("01.01.2015")
            });
            modeller.Add(new Model
            {
                ModelID = 11,
                ModelAdi = "1.001 Fire",
                Fiyati = 5000,
                UretimYili = DateTime.Parse("01.01.2015")
            });
            return modeller;

        }

    }
}
