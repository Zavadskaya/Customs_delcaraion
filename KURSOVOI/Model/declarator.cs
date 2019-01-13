namespace KURSOVOI.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("declarator")]
    public partial class declarator
    {
        [Key]
        public int id_declarator { get; set; }

        [Required]
        [StringLength(50)]
        public string lastName { get; set; }

        [Required]
        [StringLength(50)]
        public string firstName { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string jobTitle { get; set; }
    }
}
