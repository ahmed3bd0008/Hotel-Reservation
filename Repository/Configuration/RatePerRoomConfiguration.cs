using Entity.Core;
using Microsoft.EntityFrameworkCore;
namespace Repository.Configuration
{
    public class RatePerRoomConfiguration : IEntityTypeConfiguration<RoomRate>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<RoomRate> builder)
        {
        
           builder.HasOne(o=>o.RoomType).
                WithMany(m=>m.roomRates).
                HasForeignKey(fk=>fk.RoomTypeId).
                OnDelete(DeleteBehavior.ClientNoAction);
            builder.Property(p=>p.Price).HasPrecision(6,6);
        }
    }
}