using System.Linq.Expressions;
using ConsoleApp1.Common;

namespace ConsoleApp1.SearchingService.Builder.Criteria
{
    public class OrderingCriterion<TProp> : ICriterion
    {
        private Expression<Func<Music, TProp>> propSelector;

        public OrderingCriterion(Expression<Func<Music, TProp>> propSelector)
        {
            this.propSelector = propSelector;
        }

        public string Translate()
        {
            throw new NotImplementedException();
        }
    }
}
