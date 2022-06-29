using Refit;
using SalesTaxCalculator.Common.Models;
using SalesTaxCalculator.Common.Models.Requests;

namespace SalesTaxCalculator.Services.ApiClients;

public interface IRatesApi
{
    [Get("/v2/rates")]
    Task<IApiResponse<Rate>> GetRates(RateRequest parameters);
}