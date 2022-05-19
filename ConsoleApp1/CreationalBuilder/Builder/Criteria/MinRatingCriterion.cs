namespace ConsoleApp1.CreationalBuilder.Builder.Criteria
{
    public class MinRatingCriterion : ICriterion
    {
        private readonly double _minRating;

        public MinRatingCriterion(double minRating)
        {
            _minRating = minRating;
        }

        public string Translate()
        {
            throw new NotImplementedException();
        }
    }
}
