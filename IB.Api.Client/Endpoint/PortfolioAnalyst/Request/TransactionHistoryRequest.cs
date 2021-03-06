using System.Collections.Generic;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.PortfolioAnalyst.Request
{
    public class TransactionHistoryRequest
    {
        [JsonProperty("acctIds")]
        public List<string> AccountIds;

        [JsonProperty("conids")]
        public List<long> ConIds;

        [JsonProperty("currency")]
        public string Currency;

        [JsonProperty("days")]
        public int Days;
    }
}