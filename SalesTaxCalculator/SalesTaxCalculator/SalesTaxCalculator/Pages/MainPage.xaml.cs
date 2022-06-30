using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using SalesTaxCalculator.PageModels;

namespace SalesTaxCalculator.Pages
{
    [MvxTabbedPagePresentation(TabbedPosition.Root, Animated = true, NoHistory = true)]
    public partial class MainPage : MvxTabbedPage<MainPageModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}

