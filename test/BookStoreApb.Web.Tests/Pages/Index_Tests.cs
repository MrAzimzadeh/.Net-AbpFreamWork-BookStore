using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace BookStoreApb.Pages;

[Collection(BookStoreApbTestConsts.CollectionDefinitionName)]
public class Index_Tests : BookStoreApbWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
