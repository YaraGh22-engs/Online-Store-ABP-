using AbpCourse.Demo.Entities.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace AbpCourse.Demo.Data.Categories
{
    public class CategoryDataSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Category, int> categoriesRepository;

        //1- constructor to inject  Category using Repo
        public CategoryDataSeeder(IRepository<Category, int> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;

        }
        // 2- seeding data
        public async Task SeedAsync(DataSeedContext context)
        {
            if (!await categoriesRepository.AnyAsync())
            {
                // create list of cat
                var categories = new List<Category>()
            {
                new Category(id: 1,
                            nameAr:"أطعمة ومشروبات",
                            nameEn: "Food & Drinks",
                            descriptionAr:"جميع أنواع الأطعمة والمشروبات",
                            descriptionEn: "All food and drink categories"),
                new Category(id: 2,
                             nameAr:"مواد تنظيف",
                             nameEn: "Detergents",
                             descriptionAr:"المنظفات بأنواعها",
                             descriptionEn: "all materials used for cleaning"),
                new Category(id: 3,
                             nameAr:"عطور",
                             nameEn: "Fragrances",
                             descriptionAr:"العطور بأنواعها",
                             descriptionEn: "all perfumes and its sub-categories"),
                new Category(id: 4,
                             nameAr:"بلاستيك",
                             nameEn: "Plastic",
                             descriptionAr:"البلاستيك القابل للتدوير والغير قابل للتدوير",
                             descriptionEn: "all reusable and non-reusable plastic materials"),
            };
                // insert list of cat into DbSet 
                await this.categoriesRepository.InsertManyAsync(categories); // add to DbSet 'categories'
            }
        }
    }
}
