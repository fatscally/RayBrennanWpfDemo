using CommunityToolkit.Mvvm.ComponentModel;

namespace RayBrennan.Models
{
    [INotifyPropertyChanged]
    internal partial class PriceModel
    {

        [ObservableProperty]
        Time? time;

        [ObservableProperty]
        string? disclaimer;

        [ObservableProperty]
        string? chartName;

        [ObservableProperty]
        Bpi? bpi;

    }
}
