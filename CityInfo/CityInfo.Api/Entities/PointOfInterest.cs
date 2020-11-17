using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api.Entities
{
    public class PointOfInterest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("CityId")]
        public City city { get; set; }
        public int CityId { get; set; }
    }
}
