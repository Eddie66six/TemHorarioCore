using Microsoft.EntityFrameworkCore;
using TemHorario.Core.Domain;
using TemHorario.Core.Domain.Client.Entities;
using TemHorario.Repository.Map;

namespace TemHorario.Repository
{
    public class Context : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<Entity>();
            ////N:N
            //modelBuilder.Entity<ConvenioCredenciado>()
            //    .HasKey(t => new { t.IdMedico, t.IdConveio });
            //modelBuilder.Entity<ColaboradorPermissao>()
            //    .HasKey(t => new { t.IdColaborador, t.IdPermissao });

            ////General
            modelBuilder.ApplyConfiguration(new ClientMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //IConfiguration appSetting = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //// define the database to use
            //optionsBuilder.UseSqlServer(appSetting["AppSettings:ConnectionStrings:DefaultConnection"]);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TemHorarioDb;Integrated Security=true");
        }
    }
}