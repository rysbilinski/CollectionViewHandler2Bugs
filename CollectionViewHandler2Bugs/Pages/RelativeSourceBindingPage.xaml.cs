using CollectionViewHandler2Bugs.PageModels;

namespace CollectionViewHandler2Bugs.Pages;

public partial class RelativeSourceBindingPage : ContentPage
{
	public RelativeSourceBindingPage(RelativeSourceBindingPageModel pm)
	{
		this.BindingContext = pm;
        InitializeComponent();
	}
}