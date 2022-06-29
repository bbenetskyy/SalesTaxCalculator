using System;
using System.Collections.Generic;
using SalesTaxCalculator.Common.Models.Requests;
using SalesTaxCalculator.Services.ApiClients;

namespace SalesTaxCalculator.PageModels;

public class MainPageModel : BasePageModel
{
    private readonly IRatesApi _ratesApi;
    private readonly ITaxesApi _taxesApi;

    public MainPageModel(IRatesApi ratesApi, ITaxesApi taxesApi)
    {
        _ratesApi = ratesApi;
        _taxesApi = taxesApi;
    }

    public override async void ViewAppeared()
    {
        try
        {
            var rates = await _ratesApi.GetRates("90404", new()
            {
                Country = "US",
                City = "Santa Monica"
            });

            var taxes = await _taxesApi.CalculateTaxes(new()
            {
                FromCountry = "US" ,
                FromZip = "07001",
                FromState = "NJ",
                ToCountry = "US",
                ToZip = "07446",
                ToState = "NJ",
                Amount = 16.5,
                Shipping = 1.5,
                LineItems = new List<LineRequest>
                {
                    new()
                    {
                        Quantity = 1,
                        UnitPrice = 15.0,
                        ProductTaxCode = "31000"
                    }
                }
            });
        }
        catch (Exception ex)
        {
            
        }
    }
}