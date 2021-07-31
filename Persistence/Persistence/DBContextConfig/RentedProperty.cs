using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.DBContextConfig
{
    public class RentedPropertyConfig : IEntityTypeConfiguration<RentedProperty>
    {
        public void Configure(EntityTypeBuilder<RentedProperty> builder)
        {
            builder.ToTable("RentedProperty");

        }
    }
}
