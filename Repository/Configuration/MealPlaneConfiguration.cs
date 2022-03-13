using Entity.Core;
using Microsoft.EntityFrameworkCore;
namespace Repository.Configuration
{
    public class MealPlaneConfiguration : IEntityTypeConfiguration<MealPlane>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MealPlane> builder)
        {
           builder.HasOne(o=>o.MealType).
           WithMany(m=>m.MealPlanes).
           OnDelete(DeleteBehavior.
           ClientNoAction)
           .HasForeignKey(fk=>fk.MealTypeId);    
           
          
               }
    }
}