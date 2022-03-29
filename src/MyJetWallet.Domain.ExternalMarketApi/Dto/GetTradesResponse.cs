using System.Collections.Generic;
using MyJetWallet.Domain.ExternalMarketApi.Models;

namespace MyJetWallet.Domain.ExternalMarketApi.Dto;

public class GetTradesResponse
{
    public bool IsError { get; set; }
    public string ErrorMessage { get; set; }
    public List<ExchangeTrade> Trades { get; set; }
}