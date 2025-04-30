using BookStoreApb.Samples;
using Xunit;

namespace BookStoreApb.EntityFrameworkCore.Domains;

[Collection(BookStoreApbTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookStoreApbEntityFrameworkCoreTestModule>
{

}
