using Newtonsoft.Json;
using WDLT.Clients.Betfair.Enums;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairRunnerState
    {
        [JsonProperty("lastPriceTraded")]
        public double LastPriceTraded { get; set; }

        [JsonProperty("totalMatched")]
        public double? TotalMatched { get; set; }

        [JsonProperty("sortPriority")]
        public int SortPriority { get; set; }

        [JsonProperty("status")]
        public EBetfairStatus Status { get; set; }
    }
}