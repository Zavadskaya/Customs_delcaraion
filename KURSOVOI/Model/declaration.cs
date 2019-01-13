namespace KURSOVOI.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("declaration")]
    public partial class declaration
    {
        [Key]
        public int id_declaration { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        [StringLength(20)]
        public string status { get; set; }

        public int? id_customer { get; set; }

        //public int? id_product { get; set; }

        //public int? id_declarator { get; set; }

        ICollection<declaration> list;
    }
}
