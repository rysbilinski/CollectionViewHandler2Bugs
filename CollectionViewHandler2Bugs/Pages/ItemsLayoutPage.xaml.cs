using CollectionViewHandler2Bugs.PageModels;

namespace CollectionViewHandler2Bugs.Pages;

public partial class ItemsLayoutPage : ContentPage
{
    public ItemsLayoutPage(ItemsLayoutPageModel pm)
	{
		this.BindingContext = pm;
        InitializeComponent();
	}
}