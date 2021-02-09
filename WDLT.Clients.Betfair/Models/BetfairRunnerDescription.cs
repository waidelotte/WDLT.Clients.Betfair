using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairRunnerDescription
    {
        [JsonProperty("runnerName")]
        public string Name { get; set; }
    }
}