using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairAttachments
    {
        [JsonProperty("competitions")]
        public Dictionary<long, BetfairAttachCompetition> Competitions { get; set; }

        [JsonProperty("markets")]
        public Dictionary<string, BetfairAttachMarket> Markets { get; set; }

        [JsonProperty("events")]
        public Dictionary<long, BetfairAttachEvent> Events { get; set; }

        [JsonProperty("eventTypes")]
        public Dictionary<long, BetfairAttachSport> Sports { get; set; }
    }
}