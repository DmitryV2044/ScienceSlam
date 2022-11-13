namespace ScienceSlam;

public partial class VotePage : ContentPage
{
	public VotePage(VotePageModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
	}

    void SubmitResults(System.Object sender, System.EventArgs e)
    {

    }

    void FistParamClicked(System.Object sender, System.EventArgs e)
    {
        first_param.BackgroundColor = Color.FromArgb("#fff314");
    }

    void SecondParamClicked(System.Object sender, System.EventArgs e)
    {
        SecondParam.BackgroundColor = Color.FromArgb("#f0ad11");
    }

    void ThirdParamClicked(System.Object sender, System.EventArgs e)
    {
        ThirdParam.BackgroundColor = Color.FromArgb("#14ff18");

       // SemanticScreenReader.Announce(ThirdParam.BackgroundColor);
    }
}
