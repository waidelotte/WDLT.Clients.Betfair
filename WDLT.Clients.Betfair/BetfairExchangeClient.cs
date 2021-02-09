using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using WDLT.Clients.Base;
using WDLT.Clients.Betfair.Enums;
using WDLT.Clients.Betfair.Models;

namespace WDLT.Clients.Betfair
{
    public class BetfairExchangeClient : BaseClient
    {
        public string SSOID { get; set; }

        public BetfairExchangeClient(string userAgent) : base("https://www.betfair.com", userAgent)
        {
            _client.Timeout = 20000;
        }

        private Task<T> SSOIDRequest<T>(IRestRequest request) where T : BetfairBaseJsonRequest
        {
            if (string.IsNullOrWhiteSpace(SSOID)) throw new ArgumentException("Empty SSOID");
            request.AddCookie("ssoid", SSOID);
            return RequestAsync<T>(request);
        }

        public Task<BetfairSearchResult> Events(IEnumerable<EBetfairSport> sports, IEnumerable<EBetfairMarketType> types, EBetfairOrder order, DateTimeOffset? before = null, DateTimeOffset? after = null)
        {
            var requestData = new BetfairSearchPayload
            {
                CurrencyCode = EBetfairCurrency.EUR,
                Locale = EBetfairLocale.En,
                Filter = new BetfairFilter
                {
                    ContentGroup = new BetfairContentGroup
                    {
                        Language = EBetfairLocale.En,
                        RegionCode = EBetfairRegion.UK,
                    },
                    EventTypeIds = new List<long>(sports.Select(s => (long) s)),
                    SelectBy = order,
                    TurnInPlay = true,
                    MarketTypeCodes = types.ToList(),
                    MarketStartingBefore = before,
                    MarketStartingAfter = after
                },
                Facets = new List<BetfairFacet>(new[]
                {
                    new BetfairFacet
                    {
                        Type = EBetfairFacet.EVENT_TYPE,
                        Next = new BetfairFacet
                        {
                            Type = EBetfairFacet.COMPETITION,
                            Next = new BetfairFacet
                            {
                                Type = EBetfairFacet.EVENT,
                                Next = new BetfairFacet
                                {
                                    Type = EBetfairFacet.MARKET
                                }
                            }
                        }
                    },
                })
            };

            var request = new RestRequest("/www/sports/navigation/facet/v1/search?alt=json", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(requestData), ParameterType.RequestBody);

            return RequestAsync<BetfairSearchResult>(request);
        }

        public Task<BetfairEventTypes> ByMarket(IEnumerable<string> ids, IEnumerable<EBetfairSearchType> types, int stake, bool useAuth = true)
        {
            var request = new RestRequest("/www/sports/exchange/readonly/v1/bymarket");

            request.AddQueryParameter("alt", "json");
            request.AddQueryParameter("marketIds", string.Join(",", ids));
            request.AddQueryParameter("types", string.Join(",", types));
            request.AddQueryParameter("rollupLimit", stake.ToString());
            request.AddQueryParameter("rollupModel", "STAKE");

            return useAuth ? SSOIDRequest<BetfairEventTypes>(request) : RequestAsync<BetfairEventTypes>(request);
        }

        public static string GraphUrl(string marketId, long runnerId, double handicap)
        {
            return GraphUrl(long.Parse(marketId.Split('.').Last()), runnerId, handicap);
        }

        public static string GraphUrl(long marketId, long runnerId, double handicap)
        {
            return $"https://xtsd.betfair.com/LoadRunnerInfoChartAction/?marketId={marketId}&selectionId={runnerId}&handicap={handicap.ToString(CultureInfo.InvariantCulture)}";
        }

        public Task<BetfairHistory> HistoryGraph(string marketId, long runnerId, double handicap)
        {
            return SSOIDRequest<BetfairHistory>(new RestRequest($"https://graphs.betfair.com/api/ega/history/v1?hc={handicap.ToString(CultureInfo.InvariantCulture)}&mId={marketId}&sId={runnerId}"));
        }
    }
}
