using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Models
{
    [DataContract]
    public class GetMarketInfoListRequest
    {
        [DataMember(Order = 1)] public string ExchangeName { get; set; }
    }
}