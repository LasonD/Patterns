using System.Linq.Expressions;
using ConsoleApp1.Common;
using ConsoleApp1.CreationalBuilder.Builder.Criteria;

namespace ConsoleApp1.CreationalBuilder.Builder
{
    public class MusicSearchSpecificationBuilder
    {
        private SearchSpecification _producedSearchSpecification = new();

        private LimitCriterion? _limitCriterion;
        private readonly List<ICriterion> _firstOrderCriteria = new();
        private readonly List<ICriterion> _secondOrderCriteria = new();
        private readonly List<ICriterion> _thirdOrderCriteria = new();
        private readonly List<ICriterion> _orderingCriteria = new();

        public MusicSearchSpecificationBuilder AddLimit(int limit)
        {
            _limitCriterion = new LimitCriterion(limit);

            return this;
        }

        public MusicSearchSpecificationBuilder AddGenre(string genre)
        {
            _firstOrderCriteria.Add(new GenreCriterion(genre));

            return this;
        }

        public MusicSearchSpecificationBuilder AddMinRating(double minRating)
        {
            _secondOrderCriteria.Add(new MinRatingCriterion(minRating));

            return this;
        }

        public MusicSearchSpecificationBuilder AddMaxRating(double maxRating)
        {
            _secondOrderCriteria.Add(new MaxRatingCriterion(maxRating));

            return this;
        }

        public MusicSearchSpecificationBuilder IncludePremiumMusic(bool includePremiumMusic = true)
        {
            _thirdOrderCriteria.Add(new IncludePremiumMusicCriterion(includePremiumMusic));

            return this;
        }

        public MusicSearchSpecificationBuilder IncludeUserPrivateMusic(int userId)
        {
            _thirdOrderCriteria.Add(new IncludeUserPrivateMusicCriterion(userId));

            return this;
        }

        public MusicSearchSpecificationBuilder OrderBy<TProp>(Expression<Func<Music, TProp>> selector)
        {
            _orderingCriteria.Add(new OrderingCriterion<TProp>(selector));

            return this;
        }

        public SearchSpecification Build()
        {
            var currentProduct = _producedSearchSpecification;

            if (_limitCriterion != null)
            {
                currentProduct.AddCriterion(_limitCriterion);
            }

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

            foreach (var orderingCriteria in _orderingCriteria)
            {
                currentProduct.AddCriterion(orderingCriteria);
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
