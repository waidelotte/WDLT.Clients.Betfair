using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.Betfair.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EBetfairLocale
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "en_GB")]
        EnGb,
    }
}