namespace FundamentalProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMENTANDRATING")]
    public partial class COMMENTANDRATING
    {
        public int? IDCUSTOMER { get; set; }

        public int? IDPACKAGES { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(400)]
        public string COMMENT { get; set; }

        [Key]
        [Column(Order = 1)]
        public double RATING { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }

        public virtual PACKAGE PACKAGE { get; set; }
    }
}
