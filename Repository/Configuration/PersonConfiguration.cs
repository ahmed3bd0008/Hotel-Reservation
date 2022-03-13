using Entity.Core;
using Microsoft.EntityFrameworkCore;
namespace Repository.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Person> builder)
        {
           builder.HasMany(m=>m.reserves).WithOne(o=>o.person).HasForeignKey(fk=>fk.PersonId).OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}