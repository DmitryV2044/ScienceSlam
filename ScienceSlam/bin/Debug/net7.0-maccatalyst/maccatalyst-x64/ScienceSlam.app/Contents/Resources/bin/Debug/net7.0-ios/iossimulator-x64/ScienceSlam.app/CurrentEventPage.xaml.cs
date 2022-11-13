namespace ScienceSlam;

public partial class CurrentEventPage : ContentPage
{
	public CurrentEventPage(CurrentEventPageModel cm)
	{
		InitializeComponent();
		BindingContext = cm;
	}
}
