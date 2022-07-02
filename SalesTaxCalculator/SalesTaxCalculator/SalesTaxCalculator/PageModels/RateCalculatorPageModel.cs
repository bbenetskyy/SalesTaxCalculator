using System;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using SalesTaxCalculator.Common.Interfaces;
using SalesTaxCalculator.Models;
using SalesTaxCalculator.Resources;
using SalesTaxCalculator.Services.ApiClients;
using SalesTaxCalculator.Validations;

namespace SalesTaxCalculator.PageModels;

public class RateCalculatorPageModel : BasePageModel
{
    private readonly IDialogService _dialogService;
    private readonly IRateService _rateService;
    private RateDetailsModel _rateDetailsModel;

    public RateCalculatorPageModel(
        IDialogService dialogService,
        IRateService rateService,
        IConnectivityService connectivityService,
        IMvxNavigationService navigationService,
        ILogger logger) : base(navigationService, logger, connectivityService)
    {
        _dialogService = dialogService;
        _rateService = rateService;
        CalculateRatesCommand = new MvxAsyncCommand(ExecuteCalculateRatesCommand);
        RateModel = new();
        SetValidators();
    }

    public RateModel RateModel { get; }

    public RateDetailsModel RateDetailsModel
    {
        get => _rateDetailsModel;
        set => SetProperty(ref _rateDetailsModel, value);
    }

    public IMvxCommand CalculateRatesCommand { get; }

    private async Task ExecuteCalculateRatesCommand()
    {
        try
        {
            //todo check internet connection here
            if (RateModel.Validate() is false)
            {
                await _dialogService.ShowAlert(AppResources.ValidationFailedMessage, string.Join("; ", RateModel.GetErrors()));
                return;
            }

            RateDetailsModel = await _rateService.GetRates(RateModel.ZipCode.Value, RateModel.Country.Value, RateModel.City.Value);
        }
        catch (Exception ex)
        {
            Logger.LogError(ex);
        }
    }

    private void SetValidators()
    {
        NotEmptyValidationRule<string> notEmptyValidationRule = new()
        {
            ValidationMessage = AppResources.RequiredFieldMessage
        };
        ZipCodeValidationRule<string> zipCodeValidationRule = new()
        {
            ValidationMessage = AppResources.RequiredFieldMessage
        };
        CountryCodeValidationRule<string> countryCodeValidationRule = new()
        {
            ValidationMessage = AppResources.RequiredFieldMessage
        };

        RateModel.ZipCode.Validations.Add(notEmptyValidationRule);
        RateModel.ZipCode.Validations.Add(zipCodeValidationRule);
        RateModel.Country.Validations.Add(notEmptyValidationRule);
        RateModel.Country.Validations.Add(countryCodeValidationRule);
    }
}