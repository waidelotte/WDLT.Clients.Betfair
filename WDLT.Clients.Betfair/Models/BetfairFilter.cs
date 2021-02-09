using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WDLT.Clients.Betfair.Enums;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairFilter
    {
        [JsonProperty("attachments")]
        public List<EBetfairFacet> Attachments { get; set; }

        [JsonProperty("contentGroup")]
        public BetfairContentGroup ContentGroup { get; set; }

        [JsonProperty("marketBettingTypes")]
        public List<EBetfairBettingType> MarketBettingTypes { get; set; }

        [JsonProperty("eventTypeIds")]
        public List<long> EventTypeIds { get; set; }

        [JsonProperty("maxResults")]
        public int MaxResults { get; set; }

        [JsonProperty("marketTypeCodes")]
        public List<EBetfairMarketType> MarketTypeCodes { get; set; }

        [JsonProperty("selectBy")]
        public EBetfairOrder SelectBy { get; set; }

        [JsonProperty("productTypes")]
        public List<EBetfairProduct> ProductTypes { get; set; }

        [JsonProperty("turnInPlayEnabled")]
        public bool? TurnInPlay { get; set; }

        [JsonProperty("competitionIds")]
        public List<long> CompetitionIds { get; set; }

        [JsonProperty("marketStartingBefore", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTimeOffset? MarketStartingBefore { get; set; }

        [JsonProperty("marketStartingAfter", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTimeOffset? MarketStartingAfter { get; set; }
    }
}