using BookStoreApb.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace BookStoreApb.Web.Pages;

public abstract class BookStoreApbPageModel : AbpPageModel
{
    protected BookStoreApbPageModel()
    {
        LocalizationResourceType = typeof(BookStoreApbResource);
    }
}
