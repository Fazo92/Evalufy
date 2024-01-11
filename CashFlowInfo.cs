using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalSource
{
    internal class CashFlowInfo : FinanceBaseInfo
    {
        [JsonProperty ("freeCashFlow")]
        public String FreeCashFlow { get; set; }
    }
}
