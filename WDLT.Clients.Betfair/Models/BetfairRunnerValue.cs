using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairRunnerValue
    {
        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("size")]
        public double Size { get; set; }
    }
}