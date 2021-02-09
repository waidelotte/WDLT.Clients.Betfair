using System;
using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairAttachEvent
    {
        [JsonProperty("eventId")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("OpenDate")]
        public DateTimeOffset OpenDate { get; set; }
    }
}