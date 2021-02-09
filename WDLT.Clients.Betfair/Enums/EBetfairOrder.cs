using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.Betfair.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EBetfairOrder
    {
        FIRST_TO_START_AZ,
        RANK,
        MAXIMUM_TRADED
    }
}