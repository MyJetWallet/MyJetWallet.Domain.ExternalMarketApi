using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Models
{
    [DataContract]
    public class GetBalancesRequest
    {
        [DataMember(Order = 1)] public string ExchangeName { get; set; }
    }
}