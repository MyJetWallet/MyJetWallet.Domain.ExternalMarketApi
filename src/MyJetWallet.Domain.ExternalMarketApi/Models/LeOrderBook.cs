using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Models
{
    [DataContract]
    public class LeOrderBook
    {
        [DataMember(Order = 1)] public string Symbol { get; set; }

        [DataMember(Order = 2)] public string Source { get; set; }

        [DataMember(Order = 3)] public DateTime Timestamp { get; set; }

        [DataMember(Order = 4)] public List<LeOrderBookLevel> Asks { get; set; }

        [DataMember(Order = 5)] public List<LeOrderBookLevel> Bids { get; set; }
    }
}