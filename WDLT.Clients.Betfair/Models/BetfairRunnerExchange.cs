using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairRunnerExchange
    {
        [JsonProperty("availableToBack")]
        public List<BetfairRunnerValue> AvailableToBack { get; set; }

        [JsonProperty("availableToLay")]
        public List<BetfairRunnerValue> AvailableToLay { get; set; }

        [JsonProperty("traded")]
        public List<BetfairRunnerValue> Traded { get; set; }
    }
}