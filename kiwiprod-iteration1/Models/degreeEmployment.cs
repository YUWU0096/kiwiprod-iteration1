namespace kiwiprod_iteration1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("degreeEmployment")]
    public partial class degreeEmployment
    {
        [Key]
        [StringLength(39)]
        public string Degree { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Employment_Rate { get; set; }
    }
}
