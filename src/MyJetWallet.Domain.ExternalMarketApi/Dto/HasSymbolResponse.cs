using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto
{
    [DataContract]
    public class HasSymbolResponse
    {
        [DataMember(Order = 1)] public bool Result { get; set; }
    }
}