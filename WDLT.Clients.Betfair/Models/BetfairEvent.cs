using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairEvent
    {
        [JsonProperty("eventId")]
        public long EventId { get; set; }

        [JsonProperty("marketNodes")]
        public List<BetfairMarket> MarketNodes { get; set; }
    }
}