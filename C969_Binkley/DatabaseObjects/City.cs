﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley.DatabaseObjects
{
    public class City
    {
        Random rng = new Random();
        public City()
        {
            cityId = rng.Next(1, 1000000);
        }
        public City(string inpString)
        {

        }
        public City(int cityID, string cityName, Country country)
        {
            CityId = cityID;
            CityName = cityName;
            Country = country;
        }

        private int cityId;
        public int CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }

        private string city;
        public string CityName
        {
            get { return city; }
            set { city = value; }
        }

        private Country country;
        public Country Country
        {
            get { return country; }
            set { country = value; }
        }
    }
}
