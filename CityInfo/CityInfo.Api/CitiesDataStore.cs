using CityInfo.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CityInfo.Api
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
            new CityDto()
            {
                Id = 1,
                Name = "Warsaw",
                Description = "Greatest ciy ever"
            },
            new CityDto()
            {
                Id = 2,
                Name = "Cracow",
                Description = "There might be a dragon lord, be aware!"
            },
            new CityDto()
            {
                Id = 3,
                Name = "Gorz Wlkp.",
                Description = "Short distance to Berlin"
            }
            };
        }
    }
}
