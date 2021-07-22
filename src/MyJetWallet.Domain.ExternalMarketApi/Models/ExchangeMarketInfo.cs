using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Models
{
    [DataContract]
    public class ExchangeMarketInfo
    {
        [DataMember(Order = 1)] public string Market { get; set; }
        [DataMember(Order = 2)] public int PriceAccuracy { get; set; }
        [DataMember(Order = 3)] public double MinVolume { get; set; }
        [DataMember(Order = 4)] public string BaseAsset { get; set; }
        [DataMember(Order = 5)] public string QuoteAsset { get; set; }
        [DataMember(Order = 6)] public int VolumeAccuracy { get; set; }
        [DataMember(Order = 7)] public string AssociateInstrument { get; set; }
        [DataMember(Order = 8)] public string AssociateBaseAsset { get; set; }
        [DataMember(Order = 9)] public string AssociateQuoteAsset { get; set; }
    }
}