using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore.Dtos
{
    public class LocationReadDto
    {
        public string Type { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }
}
