using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.Betfair.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EBetfairStatus
    {
        Active,
        Loser,
        Winner,
        Removed,
        Open,
        Suspended,
        Closed
    }
}