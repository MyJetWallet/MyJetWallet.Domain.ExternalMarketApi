using System.ServiceModel;
using System.Threading.Tasks;
using MyJetWallet.Domain.ExternalMarketApi.Dto;
using MyJetWallet.Domain.ExternalMarketApi.Models;
using MyJetWallet.Domain.Orders;

namespace MyJetWallet.Domain.ExternalMarketApi
{
    [ServiceContract]
    public interface IExternalMarket
    {
        [OperationContract]
        public Task<GetNameResult> GetNameAsync();
        
        
        [OperationContract]
        public Task<GetBalancesResponse> GetBalancesAsync();
        
        [OperationContract]
        public Task<GetMarketInfoResponse> GetMarketInfoAsync(MarketRequest request);
        
        [OperationContract]
        public Task<GetMarketInfoListResponse> GetMarketInfoListAsync();

        [OperationContract]
        public Task<ExchangeTrade> MarketTrade(string market, OrderSide side, double volume, string referenceId);
    }
}