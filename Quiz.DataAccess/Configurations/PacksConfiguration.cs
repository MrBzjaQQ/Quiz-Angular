using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quiz.Domain.Contants;
using Quiz.Domain.Entities;

namespace Quiz.DataAccess.Configurations;

public class PacksConfiguration: IEntityTypeConfiguration<Pack>
{
    public void Configure(EntityTypeBuilder<Pack> builder)
    {
        builder.ToTable("Packs");

        builder.HasKey(x => x.Id);

        builder
            .Property(pack => pack.Name)
            .HasMaxLength(PacksConstants.Name.Max);

        builder
            .Property(pack => pack.Author)
            .HasMaxLength(PacksConstants.Author.Max);
    }
}