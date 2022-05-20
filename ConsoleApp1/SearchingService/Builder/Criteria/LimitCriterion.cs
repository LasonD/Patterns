namespace ConsoleApp1.SearchingService.Builder.Criteria
{
    public class LimitCriterion : ICriterion
    {
        private int _limit;

        public LimitCriterion(int limit)
        {
            _limit = limit;
        }

        public string Translate()
        {
            throw new NotImplementedException();
        }
    }
}
