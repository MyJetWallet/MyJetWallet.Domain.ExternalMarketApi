using System;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto;

[DataContract]
public class GetWithdrawalsHistoryRequest
{
    [DataMember(Order = 1)] public string ExchangeName { get; set; }
    [DataMember(Order = 2)] public DateTime From { get; set; }
    [DataMember(Order = 3)] public DateTime To { get; set; }
}