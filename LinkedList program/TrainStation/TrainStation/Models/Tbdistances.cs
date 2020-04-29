using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrainStations.Models
{
    public class Tbdistances
    {
        [Key]
        public int id { get; set; }
        //[ForeignKey("Distance_1")]
        public int station1id { get; set; }
        public virtual tbStations Stations1 { get; set; }
        //[ForeignKey("Distance_2")]
        public int station2id { get; set; }
        public virtual tbStations Stations2 { get; set; }

        public int distance { get; set; }
    }
}