using System.Collections.Generic;
using Newtonsoft.Json;
using WDLT.Clients.Betfair.Enums;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairFacet
    {
        [JsonProperty("type")]
        public EBetfairFacet Type { get; set; }

        [JsonProperty("maxValues")]
        public long MaxValues { get; set; }

        [JsonProperty("skipValues")]
        public long SkipValues { get; set; }

        [JsonProperty("next")]
        public BetfairFacet Next { get; set; }

        [JsonProperty("applyNextTo")]
        public long ApplyNextTo { get; set; }

        [JsonProperty("values")]
        public List<BetfairFacetValue> Values { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }
    }
}