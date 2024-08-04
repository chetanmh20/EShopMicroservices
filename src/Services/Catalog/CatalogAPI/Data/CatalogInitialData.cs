using Marten.Schema;

namespace CatalogAPI.Data;

public class CatalogInitialData : IInitialData
{
    public Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        throw new NotImplementedException();
    }
}
