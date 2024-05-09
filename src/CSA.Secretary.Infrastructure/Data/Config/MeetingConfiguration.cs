using CSA.Secretary.Core.MeetingAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSA.Secretary.Infrastructure.Data.Config;

public class MeetingConfiguration : IEntityTypeConfiguration<Meeting>
{
  public void Configure(EntityTypeBuilder<Meeting> builder)
  {
    builder.Property(p => p.Name)
        .HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH)
        .IsRequired();
  }
}
