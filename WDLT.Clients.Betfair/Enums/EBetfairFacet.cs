using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.Betfair.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EBetfairFacet
    {
        EXCHANGE,
        COMPETITION,
        MARKET,
        EVENT,
        EVENT_TYPE
    }
}