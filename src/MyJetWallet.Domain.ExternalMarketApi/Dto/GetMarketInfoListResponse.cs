using System.Collections.Generic;
using System.Runtime.Serialization;
using MyJetWallet.Domain.ExternalMarketApi.Models;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto
{
    [DataContract]
    public class GetMarketInfoListResponse
    {
        [DataMember(Order = 1)] public List<ExchangeMarketInfo> Infos { get; set; }
    }
}