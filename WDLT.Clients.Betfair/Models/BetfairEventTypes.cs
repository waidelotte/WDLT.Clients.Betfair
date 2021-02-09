using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairEventTypes : BetfairBaseJsonRequest
    {
        [JsonProperty("eventTypes")]
        public List<BetfairEventType> EventTypes { get; set; }
    }
}