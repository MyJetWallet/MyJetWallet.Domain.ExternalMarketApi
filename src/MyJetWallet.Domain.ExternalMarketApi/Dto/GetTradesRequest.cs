using System;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto;

[DataContract]
public class GetTradesRequest
{
    [DataMember(Order = 1)] public DateTime StartDate { get; set; }
    [DataMember(Order = 2)] public DateTime EndDate { get; set; }
    [DataMember(Order = 3)] public string ExchangeName { get; set; }
}