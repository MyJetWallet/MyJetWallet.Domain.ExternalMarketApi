using System.Runtime.Serialization;
using MyJetWallet.Domain.ExternalMarketApi.Models;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto
{
    [DataContract]
    public class GetMarketInfoResponse
    {
        [DataMember(Order = 1)] public ExchangeMarketInfo Info { get; set; }
    }
}