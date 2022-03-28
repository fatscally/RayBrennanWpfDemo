using CommunityToolkit.Mvvm.ComponentModel;

namespace NoFrixionWpf.Models
{
    [INotifyPropertyChanged]
    internal partial class CurrencyModel
    {

        [ObservableProperty]
        string? code;

        [ObservableProperty]
        string? symbol;

        [ObservableProperty]
        string? rate = "0.00";

        [ObservableProperty]
        string? description;

        [ObservableProperty]
        float? rate_float;

    }
}
