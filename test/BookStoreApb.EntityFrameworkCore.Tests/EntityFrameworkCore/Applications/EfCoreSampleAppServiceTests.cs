using BookStoreApb.Samples;
using Xunit;

namespace BookStoreApb.EntityFrameworkCore.Applications;

[Collection(BookStoreApbTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookStoreApbEntityFrameworkCoreTestModule>
{

}
