using System.Collections.Generic;
using System.Runtime.Serialization;
using MyJetWallet.Domain.ExternalMarketApi.Models;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto;

[DataContract]
public class GetTradesResponse
{
    [DataMember(Order = 1)] public bool IsError { get; set; }
    [DataMember(Order = 2)] public string ErrorMessage { get; set; }
    [DataMember(Order = 3)] public List<ExchangeTrade> Trades { get; set; }
}