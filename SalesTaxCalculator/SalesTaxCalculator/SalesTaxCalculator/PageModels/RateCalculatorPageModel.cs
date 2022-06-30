using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using SalesTaxCalculator.Resources;
using SalesTaxCalculator.Validations;

namespace SalesTaxCalculator.PageModels;

public class RateCalculatorPageModel : BasePageModel
{
    private ValidatableObject<string> _zipCode;
    private ValidatableObject<string> _country;
    private ValidatableObject<string> _city;

    public RateCalculatorPageModel(IMvxNavigationService navigationService) : base(navigationService)
    {
        CalculateRatesCommand = new MvxAsyncCommand(ExecuteCalculateRatesCommand);
        SetValidators();
    }

    public ValidatableObject<string> ZipCode
    {
        get => _zipCode;
        set => SetProperty(ref _zipCode, value);
    }

    public ValidatableObject<string> Country
    {
        get => _country;
        set => SetProperty(ref _country, value);
    }

    public ValidatableObject<string> City
    {
        get => _city;
        set => SetProperty(ref _city, value);
    }
    
    public IMvxCommand CalculateRatesCommand { get; }
    
    private Task ExecuteCalculateRatesCommand()
    {
        
        return Task.CompletedTask;
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
        
        ZipCode.Validations.Add(notEmptyValidationRule);
        ZipCode.Validations.Add(zipCodeValidationRule);
        Country.Validations.Add(notEmptyValidationRule);
        Country.Validations.Add(countryCodeValidationRule);
    }
}