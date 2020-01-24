﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LocationFinder.Api.Models
{
    [Table(name: "nearme.pointlocation")]
    public class PointLocation : BaseEntity
    {
        //public Guid MarkGuid { get; set; }
        public float Latitude { get; set; }
        public float Longtitude { get; set; }

        public Person Person { get; set; }
    }
}
