using MvvmCross.ViewModels;
using SalesTaxCalculator.PageModels;

namespace SalesTaxCalculator
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainPageModel>();
        }
    }
}