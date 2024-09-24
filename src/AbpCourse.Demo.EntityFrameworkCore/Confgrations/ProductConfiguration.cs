using AbpCourse.Demo.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AbpCourse.Demo.Confgrations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product >
    {
        public void Configure(EntityTypeBuilder<Product > builder)
        {
            builder.ConfigureByConvention(); // this for auto mapping 

            builder.Property(x => x.NameAr).HasMaxLength(DemoConsts.GeneralTextMaxLength).IsRequired();
            builder.Property(x => x.NameEn).HasMaxLength(DemoConsts.GeneralTextMaxLength).IsRequired();
            builder.Property(x => x.DescriptionAr).HasMaxLength(DemoConsts.DescriptionTextMaxLength).IsRequired();
            builder.Property(x => x.DescriptionEn).HasMaxLength(DemoConsts.DescriptionTextMaxLength).IsRequired();
            // M to 1 relation
            builder.HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .IsRequired();

            builder.ToTable("Products");

        }
    }
}
