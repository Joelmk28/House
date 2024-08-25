using House.ViewModel;
namespace House.View;
using Microsoft.Maui.Controls;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
		this.BindingContext = new LandingViewModel();
        IView view = SelectionList.Children[0];
        ((RadioButton)view).IsChecked = true;
	}
}