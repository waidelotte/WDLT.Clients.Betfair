using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairMarket
    {
        [JsonProperty("marketId")]
        public string MarketId { get; set; }

        [JsonProperty("runners")]
        public List<BetfairRunner> Runners { get; set; }

        [JsonProperty("state")]
        public BetfairMarketState State { get; set; }

        [JsonProperty("description")]
        public BetfairMarketDescription Description { get; set; }
    }
}