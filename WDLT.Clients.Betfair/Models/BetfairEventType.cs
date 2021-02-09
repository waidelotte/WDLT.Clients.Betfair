using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairEventType
    {
        [JsonProperty("eventTypeId")]
        public long EventTypeId { get; set; }

        [JsonProperty("eventNodes")]
        public List<BetfairEvent> EventNodes { get; set; }
    }
}