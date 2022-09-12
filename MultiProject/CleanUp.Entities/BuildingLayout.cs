using System;
using System.Collections.Generic;

#nullable disable

namespace CleanUp.Entities
{
    public partial class BuildingLayout
    {
        public int BuildingLayoutId { get; set; }
        public int BuildingId { get; set; }
        public string SpaceName { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public string Floor { get; set; }
        public string Description { get; set; }

        public virtual Building Building { get; set; }
    }
}
