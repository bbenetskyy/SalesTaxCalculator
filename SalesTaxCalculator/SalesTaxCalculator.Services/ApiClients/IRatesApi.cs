using Refit;

namespace SalesTaxCalculator.Services.ApiClients;

public interface IRatesApi
{
    [Get("/v2/rates")]
    Task<object> GetRates(object parameters);
}