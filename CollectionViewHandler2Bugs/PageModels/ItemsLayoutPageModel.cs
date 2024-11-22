using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewHandler2Bugs.PageModels;

public partial class ItemsLayoutPageModel : ObservableObject
{
    [ObservableProperty] private List<string> items = ["Item1", "Item2", "Item3"];
}
