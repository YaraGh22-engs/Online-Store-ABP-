using AbpCourse.Demo.Samples;
using Xunit;

namespace AbpCourse.Demo.EntityFrameworkCore.Applications;

[Collection(DemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<DemoEntityFrameworkCoreTestModule>
{

}
