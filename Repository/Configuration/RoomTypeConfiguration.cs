using Entity.Core;
using Microsoft.EntityFrameworkCore;
namespace Repository.Configuration
{
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<RoomType> builder)
        {
           builder.HasMany(d=>d.roomRates).
           WithOne(o=>o.RoomType).
           HasForeignKey(fk=>fk.RoomTypeId).
           OnDelete(DeleteBehavior.ClientNoAction);
           
            builder.HasMany(d=>d.Rooms).
           WithOne(o=>o.RoomType).
           HasForeignKey(fk=>fk.RoomTypeId).
           OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}