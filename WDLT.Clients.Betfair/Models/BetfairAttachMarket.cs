using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WDLT.Clients.Betfair.Enums;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairAttachMarket
    {
        [JsonProperty("marketId")]
        public string Id { get; set; }

        [JsonProperty("eventId")]
        public long EventId { get; set; }

        [JsonProperty("totalMatched")]
        public double TotalMatched { get; set; }

        [JsonProperty("totalAvailable")]
        public double TotalAvailable { get; set; }

        [JsonProperty("marketType")]
        public EBetfairMarketType Type { get; set; }

        [JsonProperty("marketStatus")]
        public EBetfairStatus MarketStatus { get; set; }

        [JsonProperty("marketSuspendTime")]
        public DateTimeOffset? MarketSuspendTime { get; set; }

        [JsonProperty("marketName")]
        public string Name { get; set; }

        [JsonProperty("numberOfRunners")]
        public int NumberOfRunners { get; set; }

        [JsonProperty("runners")]
        public List<BetfairAttachRunner> Runners { get; set; }

        [JsonProperty("inplay")]
        public bool Inplay { get; set; }

        [JsonProperty("canTurnInPlay")]
        public bool CanTurnInPlay { get; set; }

        [JsonProperty("associatedMarkets")]
        public List<BetfairAssociatedMarket> AssociatedMarkets { get; set; }
    }
}