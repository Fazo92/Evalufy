using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalSource
{
    internal class FinanceBaseInfo
    {
        [JsonProperty ("date")]
        public String Date { get; set; }

        [JsonProperty ("symbol")]
        public String Symbol { get; set; }
    }
}
