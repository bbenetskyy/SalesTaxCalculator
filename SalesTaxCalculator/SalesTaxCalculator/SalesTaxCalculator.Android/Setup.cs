using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.IoC;

namespace SalesTaxCalculator.Droid;

public class Setup : MvxFormsAndroidSetup<CoreApp, App>
{
    protected override IMvxIoCProvider InitializeIoC()
    {
        var ioc = base.InitializeIoC();

        
        
        return ioc;
    }
}