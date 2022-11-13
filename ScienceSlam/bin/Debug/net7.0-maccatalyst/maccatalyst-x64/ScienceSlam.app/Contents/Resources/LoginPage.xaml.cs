namespace ScienceSlam;

public partial class LoginPage : ContentPage
{
	int count = 0;

	public LoginPage(LoginPageModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}


