using System.Threading.Tasks;

namespace AbpCourse.Demo.Data;

public interface IDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
