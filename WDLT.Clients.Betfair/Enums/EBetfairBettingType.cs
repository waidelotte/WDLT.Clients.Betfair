using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.Betfair.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EBetfairBettingType
    {
        ODDS,
        ASIAN_HANDICAP_DOUBLE_LINE,
        ASIAN_HANDICAP_SINGLE_LINE
    }
}