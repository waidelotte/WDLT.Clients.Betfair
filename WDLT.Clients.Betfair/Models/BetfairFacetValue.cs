using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairFacetValue
    {
        [JsonProperty("key")]
        public BetfairFacetKey Key { get; set; }

        [JsonProperty("cardinality")]
        public long Cardinality { get; set; }

        [JsonProperty("next")]
        public BetfairFacet Next { get; set; }
    }
}