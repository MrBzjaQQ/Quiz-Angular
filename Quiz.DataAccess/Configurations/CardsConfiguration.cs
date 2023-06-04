using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quiz.Domain.Contants;
using Quiz.Domain.Entities;

namespace Quiz.DataAccess.Configurations;

/// <summary>
/// This class configures <see cref="Card"/>
/// </summary>
public class CardsConfiguration: IEntityTypeConfiguration<Card>
{
    public void Configure(EntityTypeBuilder<Card> builder)
    {
        builder.ToTable("Cards");

        builder.HasKey(x => x.Id);

        builder
            .Property(card => card.Question)
            .HasMaxLength(CardsConstants.Question.Max);

        builder
            .Property(card => card.Answer)
            .HasMaxLength(CardsConstants.Answer.Max);

        builder
            .HasOne(card => card.Pack)
            .WithMany(pack => pack.Cards)
            .HasForeignKey(card => card.PackId);
    }
}