namespace ExemploHttp.Views;

using ExemploHttp.ViewModels;

public partial class PhotosView : ContentPage
{
	public PhotosView()
	{
        InitializeComponent();
		BindingContext = new PhotosViewModel();
	}
}