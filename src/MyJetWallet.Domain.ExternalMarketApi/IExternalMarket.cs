using System.ServiceModel;
using System.Threading.Tasks;
using MyJetWallet.Domain.ExternalMarketApi.Dto;
using MyJetWallet.Domain.ExternalMarketApi.Models;

namespace MyJetWallet.Domain.ExternalMarketApi
{
    [ServiceContract]
    public interface IExternalMarket
    {
        [OperationContract]
        public Task<GetNameResult> GetNameAsync(GetNameRequest request);

        [OperationContract]
        public Task<GetBalancesResponse> GetBalancesAsync(GetBalancesRequest request);
        
        [OperationContract]
        public Task<GetMarketInfoResponse> GetMarketInfoAsync(MarketRequest request);
        
        [OperationContract]
        public Task<GetMarketInfoListResponse> GetMarketInfoListAsync(GetMarketInfoListRequest request);

        [OperationContract]
        public Task<ExchangeTrade> MarketTrade(MarketTradeRequest request);
    }
}