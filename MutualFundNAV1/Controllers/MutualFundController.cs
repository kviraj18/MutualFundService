using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MutualFundNAV1.Repositories;
using MutualFundNAV1.Services;
using System.Net.Http;

namespace MutualFundNAV1.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]

        public class MutualFundController : Controller
        {
            private readonly IMutualFundService _mutualFundService;

            public MutualFundController(IMutualFundService fundService)
            {
                _mutualFundService = fundService;
            }

            [HttpGet("{MutualFundname}")]
            public ActionResult<double> MutualFundNav(string MutualFundname)
            {
                    if(MutualFundname==null)
                    {
                         return this.BadRequest();
                    }
                return _mutualFundService.GetNavValue(MutualFundname);
            }
        }


}

