using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualFundNAV1.Services
{
    public interface IMutualFundService
    {
        public double GetNavValue(string MutualFundname);
    }
}
