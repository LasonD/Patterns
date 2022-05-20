namespace ConsoleApp1.SearchingService.Builder.Criteria
{
    public class IncludePremiumMusicCriterion : ICriterion
    {
        private readonly bool _includePremiumMusic;

        public IncludePremiumMusicCriterion(bool includePremiumMusic)
        {
            _includePremiumMusic = includePremiumMusic;
        }

        public string Translate()
        {
            throw new NotImplementedException();
        }
    }
}
