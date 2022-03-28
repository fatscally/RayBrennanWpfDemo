using CommunityToolkit.Mvvm.ComponentModel;

namespace NoFrixionWpf.Models
{
    [INotifyPropertyChanged]
    internal partial class Time
    {

        [ObservableProperty]
        string? updated;

        [ObservableProperty]
        string? updatedISO;

        [ObservableProperty]
        string? updateduk;

    }
}
