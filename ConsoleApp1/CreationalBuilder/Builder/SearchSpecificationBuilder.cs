using ConsoleApp1.CreationalBuilder.Builder.Criteria;

namespace ConsoleApp1.CreationalBuilder.Builder
{
    public class SearchSpecificationBuilder
    {
        private SearchSpecification _producedSearchSpecification = new();

        private readonly List<ICriterion> _firstOrderCriteria = new();
        private readonly List<ICriterion> _secondOrderCriteria = new();
        private readonly List<ICriterion> _thirdOrderCriteria = new();

        public SearchSpecificationBuilder AddGenre(string genre)
        {
            _firstOrderCriteria.Add(new GenreCriterion(genre));

            return this;
        }

        public SearchSpecificationBuilder AddMinRating(double minRating)
        {
            _secondOrderCriteria.Add(new MinRatingCriterion(minRating));

            return this;
        }

        public SearchSpecificationBuilder AddMaxRating(double maxRating)
        {
            _secondOrderCriteria.Add(new MaxRatingCriterion(maxRating));

            return this;
        }

        public SearchSpecificationBuilder IncludePremiumMusic(bool includePremiumMusic = true)
        {
            _thirdOrderCriteria.Add(new IncludePremiumMusicCriterion(includePremiumMusic));

            return this;
        }

        public SearchSpecificationBuilder IncludeUserPrivateMusic(int userId)
        {
            _thirdOrderCriteria.Add(new IncludeUserPrivateMusicCriterion(userId));

            return this;
        }

        public SearchSpecification Build()
        {
            var currentProduct = _producedSearchSpecification;

            foreach (var firstOrderCriteria in _firstOrderCriteria)
            {
                currentProduct.AddCriterion(firstOrderCriteria);
            }

            foreach (var secondOrderCriteria in _secondOrderCriteria)
            {
                currentProduct.AddCriterion(secondOrderCriteria);
            }

            foreach (var thirdOrderCriteria in _thirdOrderCriteria)
            {
                currentProduct.AddCriterion(thirdOrderCriteria);
            }

            Reset();

            return currentProduct;
        }

        public void Reset()
        {
            _producedSearchSpecification = new SearchSpecification();
        }
    }
}
