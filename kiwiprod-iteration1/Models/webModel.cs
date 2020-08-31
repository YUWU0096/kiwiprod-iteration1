namespace kiwiprod_iteration1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class webModel : DbContext
    {
        public webModel()
            : base("name=webModel")
        {
        }

        public virtual DbSet<degreeEmployment> degreeEmployments { get; set; }
        public virtual DbSet<EducationLevelSet> EducationLevelSets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<degreeEmployment>()
                .Property(e => e.Degree)
                .IsUnicode(false);

            modelBuilder.Entity<degreeEmployment>()
                .Property(e => e.Employment_Rate)
                .HasPrecision(17, 14);
        }
    }
}
