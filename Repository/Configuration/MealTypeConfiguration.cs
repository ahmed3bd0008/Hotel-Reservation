using Entity.Core;
using Microsoft.EntityFrameworkCore;
namespace Repository.Configuration
{
    public class MealTypeConfiguration : IEntityTypeConfiguration<MealType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MealType> builder)
        {
            builder.HasMany(o=>o.MealPerPeoples).
            WithOne(m=>m.MealType).
            OnDelete(DeleteBehavior.
            ClientNoAction)
           .HasForeignKey(fk=>fk.MealTypeId);    

            builder.HasMany(o=>o.MealPlanes).
            WithOne(m=>m.MealType).
            OnDelete(DeleteBehavior.
            ClientNoAction)
           .HasForeignKey(fk=>fk.MealTypeId);    
        }
    }
}