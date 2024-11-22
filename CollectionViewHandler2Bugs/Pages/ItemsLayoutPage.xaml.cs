using CollectionViewHandler2Bugs.PageModels;

namespace CollectionViewHandler2Bugs;

public partial class ItemsLayoutPage : ContentPage
{
    public ItemsLayoutPage(ItemsLayoutPageModel pm)
	{
		this.BindingContext = pm;
        InitializeComponent();
	}
}