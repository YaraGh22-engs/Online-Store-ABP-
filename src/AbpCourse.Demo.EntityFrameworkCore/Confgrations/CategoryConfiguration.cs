using AbpCourse.Demo.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AbpCourse.Demo.Confgrations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ConfigureByConvention(); // this for auto mapping 

            // special configs for property of category class
            builder.Property(x => x.Id).ValueGeneratedNever(); // to seed id by ME not automatic 

            builder.Property(x => x.NameAr).HasMaxLength(DemoConsts.GeneralTextMaxLength).IsRequired();
            builder.Property(x => x.NameEn).HasMaxLength(DemoConsts.GeneralTextMaxLength).IsRequired();
            builder.Property(x => x.DescriptionAr).HasMaxLength(DemoConsts.DescriptionTextMaxLength).IsRequired();
            builder.Property(x => x.DescriptionEn).HasMaxLength(DemoConsts.DescriptionTextMaxLength).IsRequired();

            builder.ToTable("Categories"); // this important

        }
    }
}
