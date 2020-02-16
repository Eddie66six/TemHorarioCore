using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemHorario.Core.Domain.Client.Entities;

namespace TemHorario.Repository.Map
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(p => p.ClientId);
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.Property(p => p.LastName).HasMaxLength(200);
            builder.Property(p => p.Email).HasMaxLength(320);
            builder.Property(p => p.Password).HasMaxLength(20);
            builder.Property(p => p.ValidationCode).HasMaxLength(6);
            builder.Property(p => p.RegisterDate);

            //builder.HasMany(p => p.Accesses)
            //    .WithOne(p => p.User).OnDelete(DeleteBehavior.Restrict);
            //builder.HasMany(p => p.Links)
            //    .WithOne(p => p.User).OnDelete(DeleteBehavior.Restrict);
        }
    }
}