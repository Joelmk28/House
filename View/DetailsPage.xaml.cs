using House.Model;
using House.ViewModel;


namespace House.View;


public partial class DetailsPage : ContentPage
{
	

    public DetailsPage(Model.Property selectedProperty)
	{
		InitializeComponent();
		var viewModel = new DetailsViewModel();
		viewModel.SelectedProperty = selectedProperty;
		viewModel.PropertyImages = selectedProperty.Images.Take(2).ToList();	
		viewModel.ModeItems = selectedProperty.Images.Count - 2;

        this.BindingContext = viewModel;

		
		
	}
}