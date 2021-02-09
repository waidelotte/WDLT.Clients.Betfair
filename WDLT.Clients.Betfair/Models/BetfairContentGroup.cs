using Newtonsoft.Json;
using WDLT.Clients.Betfair.Enums;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairContentGroup
    {
        [JsonProperty("language")]
        public EBetfairLocale Language { get; set; }

        [JsonProperty("regionCode")]
        public EBetfairRegion RegionCode { get; set; }
    }
}