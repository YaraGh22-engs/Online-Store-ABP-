using Volo.Abp.Modularity;

namespace AbpCourse.Demo;

/* Inherit from this class for your domain layer tests. */
public abstract class DemoDomainTestBase<TStartupModule> : DemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
