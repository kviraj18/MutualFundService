using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MutualFundNAV1.Models;

namespace MutualFundNAV1.Repositories
{
    public class MutualFundRepository : IMutualFundRepository
    {
        public double GetNavValue(string MutualFundname)
        {
            MutualFund Mutualfund= MutualFundHelper.mutualfunds.SingleOrDefault(p => p.MutualFundName == MutualFundname);
            return Mutualfund.MutualFundValue;

        }
    }
}
