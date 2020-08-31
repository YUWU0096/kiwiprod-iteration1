namespace kiwiprod_iteration1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EducationLevelSet")]
    public partial class EducationLevelSet
    {
        public int Id { get; set; }

        [Required]
        public string level { get; set; }
    }
}
