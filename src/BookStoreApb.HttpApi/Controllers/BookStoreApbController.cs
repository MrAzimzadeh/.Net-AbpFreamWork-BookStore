using BookStoreApb.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BookStoreApb.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreApbController : AbpControllerBase
{
    protected BookStoreApbController()
    {
        LocalizationResource = typeof(BookStoreApbResource);
    }
}
