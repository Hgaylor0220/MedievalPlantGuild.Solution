using Microsoft.EntityFrameworkCore;

namespace MedievalPlantGuild.Models
{
    public class MedievalPlantGuildContext : DbContext
    {
        public MedievalPlantGuildContext(DbContextOptions<MedievalPlantGuildContext> options)
            : base(options)
        {
        }

        public DbSet<Plant> Plants { get; set; }
    }
}