using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalMangmentApp
{
    public class MangmentAppDbContex : DbContext
    {

        public DbSet<Appointment> appointments { get; set; }
        public DbSet<Clinician> clinicians { get; set; }

        public DbSet<Address> addresses { get; set; }

        public DbSet<Patient> patients { get; set; }

        public DbSet<Biling> bilings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Mangement_hospital");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //كسرعلاقة المتعدد في جدول الزيارة 
            modelBuilder.Entity<Patient>()
                        .HasMany(p => p.Clinicians)
                        .WithMany(c => c.Patients)
                        .UsingEntity<Appointment>()
                        .Property(A => A.DateTime).HasDefaultValueSql("getDate()")
                        ;




        }
    }
}
