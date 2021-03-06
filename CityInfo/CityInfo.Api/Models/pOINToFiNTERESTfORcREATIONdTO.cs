﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api.Models
{
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage ="You should give correct Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }
    }
}
