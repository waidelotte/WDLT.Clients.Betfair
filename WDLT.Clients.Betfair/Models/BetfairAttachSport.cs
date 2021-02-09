using Newtonsoft.Json;
using WDLT.Clients.Betfair.Enums;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairAttachSport
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("eventTypeId")]
        public EBetfairSport Sport { get; set; }
    }
}