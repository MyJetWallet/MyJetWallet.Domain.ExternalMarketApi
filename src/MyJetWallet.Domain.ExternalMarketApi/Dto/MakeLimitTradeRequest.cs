using System;
using System.Runtime.Serialization;
using MyJetWallet.Domain.Orders;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto;

[DataContract]
public class MakeLimitTradeRequest
{
    [DataMember(Order = 1)] public string Market { get; set; }
    [DataMember(Order = 2)] public OrderSide Side { get; set; }
    [DataMember(Order = 3)] public decimal Volume { get; set; }
    [DataMember(Order = 4)] public string ReferenceId { get; set; }
    [DataMember(Order = 5)] public TimeSpan TimeLimit { get; set; }
    [DataMember(Order = 6)] public decimal PriceLimit { get; set; }
    [DataMember(Order = 7)] public string ExchangeName { get; set; }
}