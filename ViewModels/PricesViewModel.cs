using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NoFrixionWpf.Data;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NoFrixionWpf.ViewModels
{
    [INotifyPropertyChanged]
    internal partial class PricesViewModel
    {


        [ICommand]
        async Task Refresh()
        {

            RefreshButtonText = "Starting";

            Price = await new RestService().GetLatestPriceAsync();
            
            RefreshButtonText = "Finished ";
            IsEnabled = true;   

        }

        [ObservableProperty]
        bool isEnabled = true;

        [ObservableProperty]
        string refreshButtonText = "Refresh Price";

        [ObservableProperty]
        Models.Price? price;

    }
}
