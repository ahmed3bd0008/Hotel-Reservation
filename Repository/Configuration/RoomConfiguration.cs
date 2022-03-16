using Entity.Core;
using Microsoft.EntityFrameworkCore;
namespace Repository.Configuration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Room> builder)
        {
           builder.HasOne(o=>o.RoomType).
           WithMany(m=>m.Rooms).
           HasForeignKey(fk=>fk.RoomTypeId).
           OnDelete(DeleteBehavior.ClientNoAction);

           builder.HasMany(m=>m.reserves).WithOne(o=>o.Room).HasForeignKey(fk=>fk.RoomId).OnDelete(DeleteBehavior.ClientNoAction);
         
        }
    }
}