using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MutualFundNAV1.Models;
using MutualFundNAV1.Repositories;
using MutualFundNAV1.Services;

namespace MutualFundNAV1.Services
{
    public class MutualFundService : IMutualFundService
    {
        private readonly IMutualFundRepository _mutualFundrepository;

        public MutualFundService(IMutualFundRepository fundRepository)
        {
            _mutualFundrepository = fundRepository;
        }
        public double GetNavValue(string MutualFundname)
        {
            return _mutualFundrepository.GetNavValue(MutualFundname);
        }

    }
}
