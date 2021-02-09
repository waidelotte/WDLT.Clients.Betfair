using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairRunner
    {
        [JsonProperty("selectionId")]
        public long RunnerId { get; set; }

        [JsonProperty("handicap")]
        public double Handicap { get; set; }

        [JsonProperty("description")]
        public BetfairRunnerDescription Description { get; set; }

        [JsonProperty("state")]
        public BetfairRunnerState State { get; set; }

        [JsonProperty("exchange")]
        public BetfairRunnerExchange Exchange { get; set; }
    }
}