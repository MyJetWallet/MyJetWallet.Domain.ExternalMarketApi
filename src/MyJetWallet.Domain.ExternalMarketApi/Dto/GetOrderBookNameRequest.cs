using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto
{
    [DataContract]
    public class GetOrderBookNameRequest
    {
        [DataMember(Order = 1)] public string ExchangeName { get; set; }
    }
}