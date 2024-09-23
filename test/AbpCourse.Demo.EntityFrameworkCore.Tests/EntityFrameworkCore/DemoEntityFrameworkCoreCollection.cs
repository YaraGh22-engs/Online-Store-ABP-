using Xunit;

namespace AbpCourse.Demo.EntityFrameworkCore;

[CollectionDefinition(DemoTestConsts.CollectionDefinitionName)]
public class DemoEntityFrameworkCoreCollection : ICollectionFixture<DemoEntityFrameworkCoreFixture>
{

}
