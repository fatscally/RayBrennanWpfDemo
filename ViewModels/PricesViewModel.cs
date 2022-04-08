using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RayBrennan.Data;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RayBrennan.ViewModels
{
    [INotifyPropertyChanged]
    internal partial class PricesViewModel
    {



        [ICommand]
        async Task Refresh()
        {

            RefreshButtonText = "Calling...";

            Price = await new RestService().GetLatestPriceAsync().ConfigureAwait(false);

            RefreshButtonText = "Refresh";

        }


        [ObservableProperty]
        string refreshButtonText = "Refresh Price";

        [ObservableProperty]
        Models.Price? price;

    }
}
