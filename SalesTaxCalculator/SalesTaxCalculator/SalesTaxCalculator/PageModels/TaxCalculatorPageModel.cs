using MvvmCross.Navigation;
using SalesTaxCalculator.Common.Interfaces;

namespace SalesTaxCalculator.PageModels;

public class TaxCalculatorPageModel : BasePageModel
{
    public TaxCalculatorPageModel(
        IConnectivityService connectivityService,
        IMvxNavigationService navigationService, 
        ILogger logger) 
        : base(navigationService, logger, connectivityService)
    {
    }
}