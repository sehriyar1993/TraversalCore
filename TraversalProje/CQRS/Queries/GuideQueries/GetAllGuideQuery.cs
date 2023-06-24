using MediatR;
using TraversalProje.CQRS.Result.GuideResault;

namespace TraversalProje.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery: IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
