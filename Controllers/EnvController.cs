using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApiCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApiCRUD.Controllers
{
    [Route("/env")]
    [ApiController]
    public class EnvController : ControllerBase
    {
        private readonly CloudFoundryInfo _cloudFoundryInfo;

        public EnvController(CloudFoundryInfo cloudFoundryInfo)
        {
            this._cloudFoundryInfo = cloudFoundryInfo;
        }

        [HttpGet]
        public CloudFoundryInfo Get()
        {
            return _cloudFoundryInfo;
        }

    }
}
