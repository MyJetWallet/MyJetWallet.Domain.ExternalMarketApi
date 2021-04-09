using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto
{
    [DataContract]
    public class GetBalancesResponse
    {
        [DataMember(Order = 1)] public Dictionary<string, double> Balances { get; set; }
    }
}