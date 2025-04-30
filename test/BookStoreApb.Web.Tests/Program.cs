using Microsoft.AspNetCore.Builder;
using BookStoreApb;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("BookStoreApb.Web.csproj"); 
await builder.RunAbpModuleAsync<BookStoreApbWebTestModule>(applicationName: "BookStoreApb.Web");

public partial class Program
{
}
