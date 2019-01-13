namespace KURSOVOI.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        [Key]
        public int id_customer { get; set; }

        [Required]
        [StringLength(50)]
        public string customerLastName { get; set; }

        [Required]
        [StringLength(50)]
        public string customerFirstName { get; set; }

        [Column(TypeName = "date")]
        public DateTime birthDate { get; set; }

        [Required]
        [StringLength(10)]
        public string sex { get; set; }

        [Required]
        [StringLength(20)]
        public string phoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string adress { get; set; }

        [Required]
        [StringLength(50)]
        public string city { get; set; }

        [StringLength(50)]
        public string state { get; set; }

        [Required]
        [StringLength(20)]
        public string postalCode { get; set; }

        [Required]
        [StringLength(50)]
        public string country { get; set; }

        [Column(TypeName = "image")]
        public byte[] photo { get; set; }

        [StringLength(50)]
        public string declarator_name { get; set; }

        [StringLength(50)]
        public string jobTitle { get; set; }
    }
}
