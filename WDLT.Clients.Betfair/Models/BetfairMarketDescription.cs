using Newtonsoft.Json;
using WDLT.Clients.Betfair.Enums;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairMarketDescription
    {
        [JsonProperty("marketName")]
        public string Name { get; set; }

        [JsonProperty("marketType")]
        public EBetfairMarketType Type { get; set; }
    }
}