using Volo.Abp.Modularity;

namespace BookStoreApb;

[DependsOn(
    typeof(BookStoreApbDomainModule),
    typeof(BookStoreApbTestBaseModule)
)]
public class BookStoreApbDomainTestModule : AbpModule
{

}
