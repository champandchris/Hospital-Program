using Microsoft.EntityFrameworkCore;
using hospital.Models;

namespace hospital.Data
{
    public class SymptomContext : DbContext
{
    public SymptomContext(DbContextOptions<SymptomContext> options)
        : base(options)
    {
    }
    public DbSet<Symptom> Symptoms{get;set;}
}


}