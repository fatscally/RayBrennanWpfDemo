using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;

namespace NoFrixionWpf.Models
{
    [INotifyPropertyChanged]
    internal partial class Bpi
    {

        [ObservableProperty]
        CurrencyModel? usd;

        [ObservableProperty]
        CurrencyModel? gbp;

        [ObservableProperty]
        CurrencyModel? eur;

    }
}
