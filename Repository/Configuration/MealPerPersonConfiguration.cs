using Entity.Core;
using Microsoft.EntityFrameworkCore;
namespace Repository.Configuration
{
    public class MealPerPersonConfiguration : IEntityTypeConfiguration<MealPerPerson>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MealPerPerson> builder)
        {
           builder.HasOne(d=>d.MealType).
           WithMany(m=>m.MealPerPeoples).
           HasForeignKey(fk=>fk.MealTypeId).
           OnDelete(DeleteBehavior.ClientNoAction); 

           builder.HasKey(d=>new {d.MealTypeId,d.ToDate,d.FromDate}); 
        }
    }
}