using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsProject.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
    }

    public class Cities: List<City>
    {
        public Cities()
        {
            Add(new City() { CityId = 1, CityName = "Mumbai", StateId = 1 }) ;
            Add(new City() { CityId = 2, CityName = "Pune", StateId = 1 }) ;
            Add(new City() { CityId = 3, CityName = "Nagpur", StateId = 1 }) ;
            Add(new City() { CityId = 4, CityName = "Aurangabad", StateId = 1 }) ;
            Add(new City() { CityId = 5, CityName = "Mehrauli", StateId = 2 }) ;
            Add(new City() { CityId = 6, CityName = "Firozabad", StateId = 2 }) ;
            Add(new City() { CityId = 7, CityName = "Shergarh", StateId = 2 }) ;
            Add(new City() { CityId = 8, CityName = "Shahjehabanad", StateId = 2 }) ;
        }
    }
}