using Volo.Abp.Modularity;

namespace BookStoreApb;

public abstract class BookStoreApbApplicationTestBase<TStartupModule> : BookStoreApbTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
