using Newtonsoft.Json;
using WDLT.Clients.Betfair.Enums;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairAttachRunner
    {
        [JsonProperty("selectionId")]
        public long Id { get; set; }

        [JsonProperty("handicap")]
        public double Handicap { get; set; }

        [JsonProperty("runnerName")]
        public string Name { get; set; }

        [JsonProperty("sortPriority")]
        public int Index { get; set; }

        [JsonProperty("runnerStatus")]
        public EBetfairStatus RunnerStatus { get; set; }
    }
}