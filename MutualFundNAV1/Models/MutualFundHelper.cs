using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualFundNAV1.Models
{
    
        public static class MutualFundHelper
        {
        public static List<MutualFund> mutualfunds = new List<MutualFund>()
        {
                new MutualFund
                {
                    MutualFundId = 1,
                    MutualFundName = "Liquid Funds",
                    MutualFundValue= 10

                },
                new MutualFund
                {
                    MutualFundId = 2,
                    MutualFundName = "Equity Funds",
                    MutualFundValue = 10

                },

                 new MutualFund
                 {
                     MutualFundId = 3,
                     MutualFundName = "Debt Mutual Funds",
                     MutualFundValue = 18.56
                 },

                  new MutualFund
                  {
                      MutualFundId = 4,
                      MutualFundName = "Balanced Funds",
                      MutualFundValue = 29.64

                  }


        };

    }
}
