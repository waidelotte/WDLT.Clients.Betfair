using Newtonsoft.Json;
using WDLT.Clients.Betfair.Enums;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairFacetKey
    {
        [JsonProperty("competitionId")]
        public long CompetitionId { get; set; }

        [JsonProperty("eventId")]
        public long EventId { get; set; }

        [JsonProperty("marketId")]
        public string MarketId { get; set; }

        [JsonProperty("eventTypeId")]
        public EBetfairSport Sport { get; set; }
    }
}