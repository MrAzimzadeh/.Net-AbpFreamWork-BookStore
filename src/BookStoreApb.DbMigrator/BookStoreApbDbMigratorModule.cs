using BookStoreApb.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BookStoreApb.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookStoreApbEntityFrameworkCoreModule),
    typeof(BookStoreApbApplicationContractsModule)
)]
public class BookStoreApbDbMigratorModule : AbpModule
{
}
