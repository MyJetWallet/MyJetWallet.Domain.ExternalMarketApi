using System.ServiceModel;
using System.Threading.Tasks;
using MyJetWallet.Domain.ExternalMarketApi.Dto;
using MyJetWallet.Domain.ExternalMarketApi.Models;

namespace MyJetWallet.Domain.ExternalMarketApi
{
    [ServiceContract]
    public interface IOrderBookSource
    {
        [OperationContract]
        Task<GetNameResult> GetNameAsync();

        [OperationContract]
        Task<GetSymbolResponse> GetSymbolsAsync();

        [OperationContract]
        Task<HasSymbolResponse> HasSymbolAsync(MarketRequest request);

        [OperationContract]
        Task<GetOrderBookResponse> GetOrderBookAsync(MarketRequest request);
    }
}