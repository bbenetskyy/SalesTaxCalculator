using Refit;
using SalesTaxCalculator.Common.Models;
using SalesTaxCalculator.Common.Models.Requests;

namespace SalesTaxCalculator.Services.ApiClients;

public interface ITaxesApi
{
    [Post("/v2/taxes")]
    Task<IApiResponse<Taxes>> CalculateTaxes([Body] TaxesRequest request);
}