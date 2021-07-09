using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto
{
    [DataContract]
    public class MarketRequest
    {
        [DataMember(Order = 1)] public string Market { get; set; }
        [DataMember(Order = 2)] public string ExchangeName { get; set; }
    }
}