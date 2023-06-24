using MediatR;
using TraversalProje.CQRS.Result.GuideResault;

namespace TraversalProje.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery : IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }

    }
}
