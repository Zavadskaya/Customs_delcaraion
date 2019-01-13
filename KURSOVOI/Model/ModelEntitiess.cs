namespace KURSOVOI.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelEntitiess : DbContext
    {
        public ModelEntitiess()
            : base("name=ModelEntitiess")
        {
        }

        public virtual DbSet<autorization> autorization { get; set; }
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<declaration> declaration { get; set; }
        public virtual DbSet<declarator> declarator { get; set; }
        public virtual DbSet<product> product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<customer>()
                .Property(e => e.jobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<declarator>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<declarator>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<declarator>()
                .Property(e => e.jobTitle)
                .IsUnicode(false);
        }
    }
}
