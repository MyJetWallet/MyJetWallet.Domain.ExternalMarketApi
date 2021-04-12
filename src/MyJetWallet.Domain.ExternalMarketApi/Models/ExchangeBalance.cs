using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Models
{
    [DataContract]
    public class ExchangeBalance
    {
        [DataMember(Order = 1)] public string Symbol { get; set; }
        [DataMember(Order = 2)] public decimal Free { get; set; }
        [DataMember(Order = 3)] public decimal Balance { get; set; }
    }
}