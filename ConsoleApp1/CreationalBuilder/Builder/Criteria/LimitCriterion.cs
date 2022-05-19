using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CreationalBuilder.Builder.Criteria
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
