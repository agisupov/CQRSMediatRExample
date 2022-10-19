using CQRSMediatRExample.DTO;
using MediatR;

namespace CQRSMediatRExample.Queries
{
    public record GetProductsQuery : IRequest<IEnumerable<Product>>;
}
