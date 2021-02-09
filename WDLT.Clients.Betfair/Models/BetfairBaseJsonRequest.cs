using Newtonsoft.Json;

namespace WDLT.Clients.Betfair.Models
{
    public abstract class BetfairBaseJsonRequest
    {
        [JsonProperty("faultcode")]
        public string FaultCode { get; set; }
    }
}