using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrainStations.Models
{
    public class tbStations
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Tbdistances> StationDistances1 { get; set; }
        public virtual ICollection<Tbdistances> StationDistances2 { get; set; }
    }
}