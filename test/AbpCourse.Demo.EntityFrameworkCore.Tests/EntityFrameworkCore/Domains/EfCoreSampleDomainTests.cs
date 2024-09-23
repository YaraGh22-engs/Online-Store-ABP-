using AbpCourse.Demo.Samples;
using Xunit;

namespace AbpCourse.Demo.EntityFrameworkCore.Domains;

[Collection(DemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<DemoEntityFrameworkCoreTestModule>
{

}
