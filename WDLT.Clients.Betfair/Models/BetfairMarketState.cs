using System;
using Newtonsoft.Json;
using WDLT.Clients.Betfair.Enums;

namespace WDLT.Clients.Betfair.Models
{
    public class BetfairMarketState
    {
        [JsonProperty("totalMatched")]
        public double TotalMatched { get; set; }

        [JsonProperty("totalAvailable")]
        public double TotalAvailable { get; set; }

        [JsonProperty("status")]
        public EBetfairStatus Status { get; set; }

        [JsonProperty("runnersVoidable")]
        public bool RunnersVoidable { get; set; }

        [JsonProperty("numberOfRunners")]
        public int NumberOfRunners { get; set; }

        [JsonProperty("inplay")]
        public bool Inplay { get; set; }

        [JsonProperty("lastMatchTime")]
        public DateTimeOffset LastMatchTime { get; set; }
    }
}