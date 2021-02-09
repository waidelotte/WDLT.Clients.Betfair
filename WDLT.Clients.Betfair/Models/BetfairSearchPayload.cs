using System.Collections.Generic;
using Newtonsoft.Json;
using WDLT.Clients.Betfair.Enums;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairSearchPayload
    {
        [JsonProperty("filter")]
        public BetfairFilter Filter { get; set; }

        [JsonProperty("facets")]
        public List<BetfairFacet> Facets { get; set; }

        [JsonProperty("currencyCode")]
        public EBetfairCurrency CurrencyCode { get; set; }

        [JsonProperty("locale")]
        public EBetfairLocale Locale { get; set; }
    }
}