using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualFundNAV1.Repositories
{
    public interface IMutualFundRepository
    {
        public double GetNavValue(string MutualFundname);
    }
}
