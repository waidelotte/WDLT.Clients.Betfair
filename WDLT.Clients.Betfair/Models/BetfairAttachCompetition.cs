using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairAttachCompetition
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("competitionId")]
        public long CompetitionId { get; set; }
    }
}