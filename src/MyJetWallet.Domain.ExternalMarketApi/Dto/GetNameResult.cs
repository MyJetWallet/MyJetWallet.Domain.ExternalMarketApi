using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto
{
    [DataContract]
    public class GetNameResult
    {
        [DataMember(Order = 1)] public string Name { get; set; }
    }
}