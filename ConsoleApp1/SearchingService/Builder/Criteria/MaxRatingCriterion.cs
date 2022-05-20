namespace ConsoleApp1.SearchingService.Builder.Criteria
{
    public class MaxRatingCriterion : ICriterion
    {
        private readonly double _maxRating;

        public MaxRatingCriterion(double maxRating)
        {
            _maxRating = maxRating;
        }

        public string Translate()
        {
            throw new NotImplementedException();
        }
    }
}
