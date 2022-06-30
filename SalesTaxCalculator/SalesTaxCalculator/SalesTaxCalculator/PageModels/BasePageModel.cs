using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace SalesTaxCalculator.PageModels;

public class BasePageModel : MvxViewModel
{
    protected IMvxNavigationService NavigationService { get; }

    public BasePageModel(IMvxNavigationService navigationService)
    {
        NavigationService = navigationService;
    }
}