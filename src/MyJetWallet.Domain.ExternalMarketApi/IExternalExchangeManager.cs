using System.ServiceModel;
using System.Threading.Tasks;
using MyJetWallet.Domain.ExternalMarketApi.Models;

namespace MyJetWallet.Domain.ExternalMarketApi
{
    [ServiceContract]
    public interface IExternalExchangeManager
    {
        [OperationContract]
        public Task<GetExternalExchangeCollectionResponse> GetExternalExchangeCollectionAsync();
    }
}