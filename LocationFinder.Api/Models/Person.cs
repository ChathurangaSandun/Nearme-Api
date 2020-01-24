﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LocationFinder.Api.Models
{
    [Table(name: "nearme.person")]
    public class Person : BaseEntity
    {
        public long OrganizationId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string ImageUri { get; set; }


        [ForeignKey("PointLocation")]
        public long PointLocatioId { get; set; }
        public PointLocation PointLocation { get; set; }
        public Organization Organization { get; set; }

    }
}
