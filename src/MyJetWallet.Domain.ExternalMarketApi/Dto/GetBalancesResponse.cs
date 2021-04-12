using System.Collections.Generic;
using System.Runtime.Serialization;
using MyJetWallet.Domain.ExternalMarketApi.Models;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto
{
    [DataContract]
    public class GetBalancesResponse
    {
        [DataMember(Order = 1)] public List<ExchangeBalance> Balances { get; set; }
    }
}