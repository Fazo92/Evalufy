using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalSource
{
    internal class BalanceSheetInfo : FinanceBaseInfo
    {
        [JsonProperty ("totalDebt")]
        public String TotalDebt { get; set; }
    }
}
