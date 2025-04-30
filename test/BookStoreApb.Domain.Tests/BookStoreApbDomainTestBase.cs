using Volo.Abp.Modularity;

namespace BookStoreApb;

/* Inherit from this class for your domain layer tests. */
public abstract class BookStoreApbDomainTestBase<TStartupModule> : BookStoreApbTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
