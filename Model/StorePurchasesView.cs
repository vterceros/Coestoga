namespace WebApplication2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StorePurchasesView")]
    public partial class StorePurchasesView
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string StoreName { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime InvoiceDate { get; set; }

        [StringLength(500)]
        public string ItemDescription { get; set; }

        [StringLength(150)]
        public string Category { get; set; }

        public decimal? UnitPriceUSD { get; set; }
    }
}
