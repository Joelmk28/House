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

		SetViewPositions();

		Loaded += (s, e) =>
		{
			FadeAndScale(detailsBtn);
			RotationView(detailsBtn);
			FadeAndTranslate(imagesView);

			Task.Delay(500);

            FadeAndTranslate(popView, 1000,1000);
            FadeAndTranslate(addressView, 1000, 1000);
            FadeAndScale(buyBtn,1000,1000);
            
        };
	
	}

    private void SetViewPositions()
    {
		detailsBtn.Opacity = 0;
		detailsBtn.Scale = 0.2;
		detailsBtn.Rotation = 300;

		imagesView.TranslationX = 300;
		imagesView.Opacity = 0;

		addressView.TranslationX = addressView.TranslationY = -30;
		buyBtn.Opacity = 0;
		buyBtn.Scale = 0.2;

		popView.TranslationY = 300;
		popView.Opacity = 0.5;


	}

	private void FadeAndTranslate(VisualElement visualElement,uint fadelength = 1000,uint translateLength = 1500)
	{
		visualElement.FadeTo(1, fadelength, Easing.SinInOut);
        visualElement.TranslateTo(1,0, translateLength, Easing.SinInOut);

    }

    private void FadeAndScale(VisualElement visualElement, uint fadelength = 1000, uint scaleLength = 1500)
    {
        visualElement.FadeTo(1, fadelength, Easing.SinInOut);
        visualElement.ScaleTo(1, scaleLength, Easing.SinInOut);

    }
	private void RotationView(VisualElement visualElement) { 
		visualElement.RotateTo(0, 1500, Easing.SinInOut);
	}
}