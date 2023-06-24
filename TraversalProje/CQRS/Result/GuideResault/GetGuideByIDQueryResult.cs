namespace TraversalProje.CQRS.Result.GuideResault
{
    public class GetGuideByIDQueryResult
    {
        public int GuideID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
