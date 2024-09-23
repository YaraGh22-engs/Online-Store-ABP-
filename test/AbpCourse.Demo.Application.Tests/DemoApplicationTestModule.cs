using Volo.Abp.Modularity;

namespace AbpCourse.Demo;

[DependsOn(
    typeof(DemoApplicationModule),
    typeof(DemoDomainTestModule)
)]
public class DemoApplicationTestModule : AbpModule
{

}
