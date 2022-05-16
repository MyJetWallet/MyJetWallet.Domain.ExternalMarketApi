using System;
using System.Runtime.Serialization;
using MyJetWallet.Domain.Orders;

namespace MyJetWallet.Domain.ExternalMarketApi.Models;

[DataContract]
public class Deposit
{
    [DataMember(Order = 1)] public string Symbol { get; set; }
    [DataMember(Order = 2)] public string TxId { get; set; }
    [DataMember(Order = 3)] public string Id { get; set; }
    [DataMember(Order = 4)] public decimal Fee { get; set; }
    [DataMember(Order = 5)] public decimal Amount { get; set; }
    [DataMember(Order = 6)] public string Note { get; set; }
    //[DataMember(Order = 6)] public OperationStatus Status { get; set; }
}