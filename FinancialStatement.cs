using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace EvalSource
{
    internal class FinancialStatement : FinanceBaseInfo
    {
        [JsonProperty("symbol")]
        public String Symbol { get; set; }
    }
}
