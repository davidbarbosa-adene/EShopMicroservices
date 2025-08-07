using Marten.Linq.QueryHandlers;

namespace Catalog.API.Products.GetProductById
{

    public record GetProductBydIdQuery(Guid Id) : IQuery<GetProductByIdResult>;
    public record GetProductByIdResult(Product Product);

    internal class GetProductByIdHandler
        (IDocumentSession session, ILogger logger)
        : IQueryHandler<GetProductBydIdQuery, GetProductByIdResult>
    {
        public async Task<GetProductByIdResult> Handle(GetProductBydIdQuery query, CancellationToken cancellationToken)
        {
            logger.LogInformation("GetProductByIdHandler. Handle called with {@query}", query);

            var product = await session.LoadAsync<Product>(query.Id, cancellationToken);

            if (product is null)
                throw new ProductNotFoundException();

            return new GetProductByIdResult(product);
        }
    }
}
