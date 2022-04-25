using Microsoft.EntityFrameworkCore;
using hospital.Models;

namespace hospital.Data
{
    public class PatientContext : DbContext
{
    public PatientContext(DbContextOptions<PatientContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    public DbSet<Patient> Patients{get;set;}
    
}


}


