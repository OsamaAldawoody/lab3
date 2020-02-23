namespace lab3
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class lab3Model : DbContext
    {
        public lab3Model()
            : base("name=lab3Model")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.Instructors)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.Dept_Id);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.Departments)
                .WithOptional(e => e.Instructor)
                .HasForeignKey(e => e.Dept_Manager);
        }
    }
}
