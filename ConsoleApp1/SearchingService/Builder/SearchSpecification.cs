using ConsoleApp1.SearchingService.Builder.Criteria;

namespace ConsoleApp1.SearchingService.Builder
{
    public class SearchSpecification
    {
        private readonly List<ICriterion> _criteria = new List<ICriterion>();

        public void AddCriterion(ICriterion criterion) => _criteria.Add(criterion);

        public void RemoveCriterion(ICriterion criterion) => _criteria.Remove(criterion);

        public string TranslateToRequest() => string.Join(":", _criteria.Select(x => x.Translate()));
    }
}
