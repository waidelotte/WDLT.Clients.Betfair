using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairHistory : BetfairBaseJsonRequest
    {
        [JsonProperty("series")]
        public List<List<object>> Series { get; set; }
    }
}