using Refit;

namespace SalesTaxCalculator.Services.ApiClients;

public interface ITaxesApi
{
    [Post("/v2/taxes")]
    Task<object> CalculateTaxes([Body] object request);
}