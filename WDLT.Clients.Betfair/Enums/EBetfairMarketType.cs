using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.Betfair.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EBetfairMarketType
    {
        OVER_UNDER_85,
        OVER_UNDER_75,
        OVER_UNDER_65,
        OVER_UNDER_55,
        OVER_UNDER_45,
        OVER_UNDER_35,
        OVER_UNDER_25,
        OVER_UNDER_15,
        OVER_UNDER_05,
        FIRST_HALF_GOALS_05,
        FIRST_HALF_GOALS_15,
        FIRST_HALF_GOALS_25,
        MATCH_ODDS,
        MATCH_ODDS_UNMANAGED,
        BOTH_TEAMS_TO_SCORE,
        CORRECT_SCORE,
        HALF_TIME,
        DOUBLE_CHANCE,
        ASIAN_HANDICAP,
        HALF_TIME_FULL_TIME,
        ALT_TOTAL_GOALS,
        MONEY_LINE,
        RT_MATCH_ODDS,
        HANDICAP,
        COMBINED_TOTAL,
        HALF_TIME_SCORE,
        NEXT_GOAL,
        SET_WINNER,
        SET_BETTING,
        NUMBER_OF_SETS,
        MAP_WINNER,
        DRAW_NO_BET
    }
}