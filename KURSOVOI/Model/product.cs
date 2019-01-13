namespace KURSOVOI.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [Key]
        public int id_product { get; set; }

        [Required]
        [StringLength(50)]
        public string productCategory { get; set; }

        [Required]
        [StringLength(50)]
        public string productName { get; set; }

        [Required]
        [StringLength(50)]
        public string productScale { get; set; }

        [Required]
        [StringLength(100)]
        public string productInfo { get; set; }

        [Required]
        [StringLength(50)]
        public string productCampony { get; set; }

        [Required]
        [StringLength(50)]
        public string unitPrice { get; set; }
    }
}
