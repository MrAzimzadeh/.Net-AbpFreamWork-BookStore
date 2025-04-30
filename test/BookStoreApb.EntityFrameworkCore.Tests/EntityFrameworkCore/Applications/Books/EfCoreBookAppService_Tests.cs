using BookStoreApb.Books;
using Xunit;

namespace BookStoreApb.EntityFrameworkCore.Applications.Books;

[Collection(BookStoreApbTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<BookStoreApbEntityFrameworkCoreTestModule>
{

}