using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using BookStoreApb.Localization;

namespace BookStoreApb.Web;

[Dependency(ReplaceServices = true)]
public class BookStoreApbBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BookStoreApbResource> _localizer;

    public BookStoreApbBrandingProvider(IStringLocalizer<BookStoreApbResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
