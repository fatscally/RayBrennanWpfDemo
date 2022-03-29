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

        static int count;

        /// <summary>
        /// Async call does not re-enable the button.
        /// </summary>
        /// <returns></returns>
        [ICommand]
        async Task Refresh()
        {

            RefreshButtonText = "Starting";

            Price = await new RestService().GetLatestPriceAsync();

            RefreshButtonText = "Finished ";

        }


        /// <summary>
        /// Non async button call works as expected.
        /// </summary>
        [ICommand]
        void UpdateText()
        {
            RefreshButtonText = "Hello World " + count++.ToString();
        }

        [ObservableProperty]
        string refreshButtonText = "Refresh Price";

        [ObservableProperty]
        Models.Price? price;

    }
}
