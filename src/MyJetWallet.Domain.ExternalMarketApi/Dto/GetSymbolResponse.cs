using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto
{
    [DataContract]
    public class GetSymbolResponse
    {
        [DataMember(Order = 1)] public List<string> Symbols { get; set; }
    }
}