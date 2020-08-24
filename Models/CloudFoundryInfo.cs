using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApiCRUD.Models
{
    public class CloudFoundryInfo
    {

        public string Port { get; }
        public string MemoryLimit { get; }
        public string CfInstanceIndex { get; }
        public string CfInstanceAddr { get; }

        public CloudFoundryInfo(string port, string memoryLimit, string cfInstanceIndex, string cfInstanceAddress)
        {
            this.Port = port;
            this.MemoryLimit = memoryLimit;
            this.CfInstanceIndex = cfInstanceIndex;
            this.CfInstanceAddr = cfInstanceAddress;
        }
    }
}
