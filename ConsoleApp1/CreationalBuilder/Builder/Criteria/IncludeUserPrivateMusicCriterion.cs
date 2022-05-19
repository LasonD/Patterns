using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CreationalBuilder.Builder.Criteria
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
