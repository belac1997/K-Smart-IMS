using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProjectTest.Models
{
    internal class SeedUsers : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasData(
                new User { Id = "1", UserName = "ctran", Email = "cody.tran@go.sfcollege.edu", EmailConfirmed = true, Firstname = "Cody", Lastname = "Tran", Password = "P@ssword1" });
        }
    }
}
