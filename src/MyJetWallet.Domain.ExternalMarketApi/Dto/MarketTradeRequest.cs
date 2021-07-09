using System.Runtime.Serialization;
using MyJetWallet.Domain.Orders;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto
{
    [DataContract]
    public class MarketTradeRequest
    {
        [DataMember(Order = 1)] public string Market { get; set; }
        [DataMember(Order = 2)] public OrderSide Side { get; set; }
        [DataMember(Order = 3)] public double Volume { get; set; }
        [DataMember(Order = 4)] public string ReferenceId { get; set; }
        [DataMember(Order = 5)] public double OppositeVolume { get; set; }
        [DataMember(Order = 6)] public string ExchangeName { get; set; }
    }
}