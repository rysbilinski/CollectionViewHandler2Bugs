using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CollectionViewHandler2Bugs.PageModels;

public partial class RelativeSourceBindingPageModel : ObservableObject
{
    [ObservableProperty] private List<string> items = [ "Item1", "Item2", "Item3" ];

    [RelayCommand] private async Task ShowDialog(string item) => await Shell.Current.DisplayAlert("Alert", item, "OK");
}
