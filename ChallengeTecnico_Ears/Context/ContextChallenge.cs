using ChallengeTecnico_Ears.Models;
using Microsoft.EntityFrameworkCore;


using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChallengeTecnico_Ears.Context
{
    public class ContextChallenge : DbContext
    {
        public ContextChallenge(DbContextOptions<ContextChallenge> options) : base(options)
        {

        }

        public DbSet<PersonModel> T_Person { get; set; }
        public DbSet<OfficeModel> T_Offices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PersonModel>();

            modelBuilder.Entity<OfficeModel>();

            modelBuilder.Entity<OfficeModel>()
            .HasOne(o => o.Person)
            .WithMany(p => p.Offices)  
            .HasForeignKey(o => o.IdPerson);


            modelBuilder.Entity<PersonModel>().HasData(

            new PersonModel { Id = 1, Name = "John Doe", Dni = 429052984, EmployeeFile = 1001, Active = true },

            new PersonModel { Id = 2, Name = "Alice Smith", Dni = 973347851, EmployeeFile = 1002, Active = true },

            new PersonModel { Id = 3, Name = "Bob Johnson", Dni = 327813549, EmployeeFile = 1003, Active = false },

            new PersonModel { Id = 4, Name = "Emily Brown", Dni = 360802010, EmployeeFile = 1004, Active = true },

            new PersonModel { Id = 5, Name = "Michael Wilson", Dni = 157652163, EmployeeFile = 1005, Active = false },

            new PersonModel { Id = 6, Name = "Emma Davis", Dni = 990772592, EmployeeFile = 1006, Active = true },

            new PersonModel { Id = 7, Name = "James Taylor", Dni = 517109719, EmployeeFile = 1007, Active = false },

            new PersonModel { Id = 8, Name = "Olivia Martinez", Dni = 22460317, EmployeeFile = 1008, Active = true },

            new PersonModel { Id = 9, Name = "William Jones", Dni = 453810075, EmployeeFile = 1009, Active = false },

            new PersonModel { Id = 10, Name = "Sophia Anderson", Dni = 379323607, EmployeeFile = 1010, Active = true });


            modelBuilder.Entity<OfficeModel>().HasData(

            new OfficeModel { Id = 1, CompanyName = "Company1", CUIT = 123456789, IdPerson = 1, Active = true },

            new OfficeModel { Id = 2, CompanyName = "Company2", CUIT = 987654321, IdPerson = 2, Active = false },

            new OfficeModel { Id = 3, CompanyName = "Company3", CUIT = 246810121, IdPerson = 3, Active = true },

            new OfficeModel { Id = 4, CompanyName = "Company4", CUIT = 135791113, IdPerson = 4, Active = false },

            new OfficeModel { Id = 5, CompanyName = "Company5", CUIT = 112233445, IdPerson = 5, Active = true },

            new OfficeModel { Id = 6, CompanyName = "Company6", CUIT = 998877665, IdPerson = 6, Active = false },

            new OfficeModel { Id = 7, CompanyName = "Company7", CUIT = 334455667, IdPerson = 7, Active = true },

            new OfficeModel { Id = 8, CompanyName = "Company8", CUIT = 556677889, IdPerson = 8, Active = false },

            new OfficeModel { Id = 9, CompanyName = "Company9", CUIT = 778899001, IdPerson = 9, Active = true },

            new OfficeModel { Id = 10, CompanyName = "Company10", CUIT = 102030405, IdPerson = 10, Active = false },

            new OfficeModel { Id = 11, CompanyName = "Company11", CUIT = 405060708, IdPerson = 1, Active = true },

            new OfficeModel { Id = 12, CompanyName = "Company12", CUIT = 203040506, IdPerson = 2, Active = false },

            new OfficeModel { Id = 13, CompanyName = "Company13", CUIT = 607080901, IdPerson = 3, Active = true },

            new OfficeModel { Id = 14, CompanyName = "Company14", CUIT = 102030405, IdPerson = 4, Active = false },

            new OfficeModel { Id = 15, CompanyName = "Company15", CUIT = 506070809, IdPerson = 5, Active = true },

            new OfficeModel { Id = 16, CompanyName = "Company16", CUIT = 102938475, IdPerson = 6, Active = false },

            new OfficeModel { Id = 17, CompanyName = "Company17", CUIT = 576869798, IdPerson = 7, Active = true },

            new OfficeModel { Id = 18, CompanyName = "Company18", CUIT = 384756392, IdPerson = 8, Active = false },

            new OfficeModel { Id = 19, CompanyName = "Company19", CUIT = 948573829, IdPerson = 9, Active = true },

            new OfficeModel { Id = 20, CompanyName = "Company20", CUIT = 201938475, IdPerson = 10, Active = false },

            new OfficeModel { Id = 21, CompanyName = "Company21", CUIT = 102938475, IdPerson = 1, Active = true },

            new OfficeModel { Id = 22, CompanyName = "Company22", CUIT = 938475920, IdPerson = 2, Active = false },

            new OfficeModel { Id = 23, CompanyName = "Company23", CUIT = 192837465, IdPerson = 3, Active = true },

            new OfficeModel { Id = 24, CompanyName = "Company24", CUIT = 920384756, IdPerson = 4, Active = false },

            new OfficeModel { Id = 25, CompanyName = "Company25", CUIT = 182736495, IdPerson = 5, Active = true },

            new OfficeModel { Id = 26, CompanyName = "Company26", CUIT = 204060708, IdPerson = 6, Active = false },

            new OfficeModel { Id = 27, CompanyName = "Company27", CUIT = 829384756, IdPerson = 7, Active = true },

            new OfficeModel { Id = 28, CompanyName = "Company28", CUIT = 102938475, IdPerson = 8, Active = false },

            new OfficeModel { Id = 29, CompanyName = "Company29", CUIT = 475829384, IdPerson = 9, Active = true },

            new OfficeModel { Id = 30, CompanyName = "Company30", CUIT = 394857294, IdPerson = 10, Active = false });




        }


    }
}
