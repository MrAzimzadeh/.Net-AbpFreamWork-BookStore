using Volo.Abp.Modularity;

namespace BookStoreApb;

[DependsOn(
    typeof(BookStoreApbApplicationModule),
    typeof(BookStoreApbDomainTestModule)
)]
public class BookStoreApbApplicationTestModule : AbpModule
{

}
