using MvvmCross.Forms.Platforms.Ios.Core;
using MvvmCross.IoC;

namespace SalesTaxCalculator.iOS;

public class Setup : MvxFormsIosSetup<CoreApp, App>
{
    protected override IMvxIoCProvider InitializeIoC()
    {
        var ioc = base.InitializeIoC();

        

        return ioc;
    }
}