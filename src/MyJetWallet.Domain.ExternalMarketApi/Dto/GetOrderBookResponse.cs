using System.Runtime.Serialization;
using MyJetWallet.Domain.ExternalMarketApi.Models;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto
{
    [DataContract]
    public class GetOrderBookResponse
    {
        [DataMember(Order = 1)] public LeOrderBook OrderBook { get; set; }
    }
}