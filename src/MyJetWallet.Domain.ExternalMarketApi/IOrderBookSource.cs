using System.ServiceModel;
using System.Threading.Tasks;
using MyJetWallet.Domain.ExternalMarketApi.Dto;

namespace MyJetWallet.Domain.ExternalMarketApi
{
    [ServiceContract]
    public interface IOrderBookSource
    {
        [OperationContract]
        Task<GetNameResult> GetNameAsync(GetOrderBookNameRequest request);

        [OperationContract]
        Task<GetSymbolResponse> GetSymbolsAsync(GetSymbolsRequest request);

        [OperationContract]
        Task<HasSymbolResponse> HasSymbolAsync(MarketRequest request);

        [OperationContract]
        Task<GetOrderBookResponse> GetOrderBookAsync(MarketRequest request);
    }
}