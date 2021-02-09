using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairSearchResult : BetfairBaseJsonRequest
    {
        [JsonProperty("attachments")]
        public BetfairAttachments Attachments { get; set; }

        [JsonProperty("facets")]
        public List<BetfairFacet> Facets { get; set; }
    }
}