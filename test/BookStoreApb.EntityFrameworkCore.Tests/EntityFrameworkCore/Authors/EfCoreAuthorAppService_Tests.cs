using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BookStoreApb.EntityFrameworkCore.Authors
{
    [Collection(BookStoreApbTestConsts.CollectionDefinitionName)]
    public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<BookStoreApbEntityFrameworkCoreTestModule>
    {

    }
}
