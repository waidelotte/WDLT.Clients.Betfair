using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairAssociatedMarket
    {
        [JsonProperty("eventId")]
        public long EventId { get; set; }

        [JsonProperty("eventTypeId")]
        public long EventTypeId { get; set; }

        [JsonProperty("sportsbookMarketId")]
        public string SportsbookMarketId { get; set; }
    }
}