using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto
{
    [DataContract]
    public class GetExternalExchangeCollectionResponse
    {
        [DataMember(Order = 1)] public List<string> ExchangeNames { get; set; }
    }
}