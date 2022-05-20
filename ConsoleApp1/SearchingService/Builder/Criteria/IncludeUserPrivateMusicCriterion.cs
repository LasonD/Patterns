namespace ConsoleApp1.SearchingService.Builder.Criteria
{
    public class IncludeUserPrivateMusicCriterion : ICriterion
    {
        private readonly int _userId;

        public IncludeUserPrivateMusicCriterion(int userId)
        {
            _userId = userId;
        }

        public string Translate()
        {
            throw new NotImplementedException();
        }
    }
}
