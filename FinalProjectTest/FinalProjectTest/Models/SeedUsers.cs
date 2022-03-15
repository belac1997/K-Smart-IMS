using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProjectTest.Models
{
    internal class SeedUsers : IEntityTypeConfiguration<InventoryUser>
    {
        public void Configure(EntityTypeBuilder<InventoryUser> entity)
        {
            entity.HasData(
                new InventoryUser { Id = "1", UserName = "ctran", Email = "cody.tran@go.sfcollege.edu", EmailConfirmed = true, Firstname = "Cody", Lastname = "Tran", Password = "P@ssword1" });
        }
    }
}
