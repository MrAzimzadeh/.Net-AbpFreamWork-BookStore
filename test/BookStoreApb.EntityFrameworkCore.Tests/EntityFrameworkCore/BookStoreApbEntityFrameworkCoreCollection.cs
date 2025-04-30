using Xunit;

namespace BookStoreApb.EntityFrameworkCore;

[CollectionDefinition(BookStoreApbTestConsts.CollectionDefinitionName)]
public class BookStoreApbEntityFrameworkCoreCollection : ICollectionFixture<BookStoreApbEntityFrameworkCoreFixture>
{

}
