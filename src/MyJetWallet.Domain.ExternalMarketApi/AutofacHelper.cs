using System;
using Autofac;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Grpc.Net.Client;
using JetBrains.Annotations;
using MyJetWallet.Sdk.GrpcMetrics;
using ProtoBuf.Grpc.Client;

namespace MyJetWallet.Domain.ExternalMarketApi
{
    [UsedImplicitly]
    public static class AutofacHelper
    {
        public static void RegisterExternalMarketClient(this ContainerBuilder builder, string externalMarketGrpcServiceUrl)
        {
            var factory = new ExternalMarketClientFactory(externalMarketGrpcServiceUrl);

            builder.RegisterInstance(factory.GetExternalMarketGrpc()).As<IExternalMarket>().SingleInstance();
            builder.RegisterInstance(factory.GetOrderBookSourceGrpc()).As<IOrderBookSource>().SingleInstance();
        }
    }

    [UsedImplicitly]
    public class ExternalMarketClientFactory
    {
        private readonly CallInvoker _channel;

        public ExternalMarketClientFactory(string assetsDictionaryGrpcServiceUrl)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            var channel = GrpcChannel.ForAddress(assetsDictionaryGrpcServiceUrl);
            _channel = channel.Intercept(new PrometheusMetricsInterceptor());
        }

        public IExternalMarket GetExternalMarketGrpc() => _channel.CreateGrpcService<IExternalMarket>();
        public IOrderBookSource GetOrderBookSourceGrpc() => _channel.CreateGrpcService<IOrderBookSource>();
    }
}