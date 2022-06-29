using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Refit;
using SalesTaxCalculator.Common.Interfaces;
using SalesTaxCalculator.PageModels;
using SalesTaxCalculator.Services;
using SalesTaxCalculator.Services.ApiClients;

namespace SalesTaxCalculator
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainPageModel>();
            
            var refitSettings = new RefitSettings(new NewtonsoftJsonContentSerializer());
            
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IApiConfigurator, ApiConfigurator>();

            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<ITaxesApi>(() =>
            {
                var httpClientManager = Mvx.IoCProvider.Resolve<IHttpClientFactory>();
                var apiConfigurator = Mvx.IoCProvider.Resolve<IApiConfigurator>();
                return RestService.For<ITaxesApi>(httpClientManager.CreateHttpClient(apiConfigurator.GetApiUrl(), true), refitSettings);
            });

            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IRatesApi>(() =>
            {
                var httpClientManager = Mvx.IoCProvider.Resolve<IHttpClientFactory>();
                var apiConfigurator = Mvx.IoCProvider.Resolve<IApiConfigurator>();
                return RestService.For<IRatesApi>(httpClientManager.CreateHttpClient(apiConfigurator.GetApiUrl(), true), refitSettings);
            });

        }
    }
}