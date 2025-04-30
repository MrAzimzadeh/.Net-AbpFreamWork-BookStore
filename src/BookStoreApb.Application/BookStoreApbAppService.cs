using BookStoreApb.Localization;
using Volo.Abp.Application.Services;

namespace BookStoreApb;

/* Inherit your application services from this class.
 */
public abstract class BookStoreApbAppService : ApplicationService
{
    protected BookStoreApbAppService()
    {
        LocalizationResource = typeof(BookStoreApbResource);
    }
}
