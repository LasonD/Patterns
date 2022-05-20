namespace ConsoleApp1.SearchingService.Builder.Criteria
{
    public class GenreCriterion : ICriterion
    {
        private readonly string _genre;

        public GenreCriterion(string genre)
        {
            _genre = genre;
        }

        public string Translate()
        {
            throw new NotImplementedException();
        }
    }
}
