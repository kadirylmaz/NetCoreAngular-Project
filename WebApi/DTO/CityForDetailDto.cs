

using System.Collections.Generic;

namespace NetCoreAngular_Project.DTO{
    public class CityForDetailDto{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Photo> Photos { get; set; }
    }
}