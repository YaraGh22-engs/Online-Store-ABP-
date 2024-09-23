using AbpCourse.Demo.Localization;
using Volo.Abp.Application.Services;

namespace AbpCourse.Demo;

/* Inherit your application services from this class.
 */
public abstract class DemoAppService : ApplicationService
{
    protected DemoAppService()
    {
        LocalizationResource = typeof(DemoResource);
    }
}
