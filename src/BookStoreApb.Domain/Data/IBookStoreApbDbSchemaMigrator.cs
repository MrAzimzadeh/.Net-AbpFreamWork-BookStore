using System.Threading.Tasks;

namespace BookStoreApb.Data;

public interface IBookStoreApbDbSchemaMigrator
{
    Task MigrateAsync();
}
