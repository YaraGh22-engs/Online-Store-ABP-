using AbpCourse.Demo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpCourse.Demo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DemoController : AbpControllerBase
{
    protected DemoController()
    {
        LocalizationResource = typeof(DemoResource);
    }
}
