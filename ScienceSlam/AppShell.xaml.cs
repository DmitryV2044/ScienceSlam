namespace ScienceSlam;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

      //  Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(CurrentEventPage), typeof(CurrentEventPage));
        Routing.RegisterRoute(nameof(VotePage), typeof(VotePage));
        Routing.RegisterRoute(nameof(CurrentEventAlt), typeof(CurrentEventAlt));

    }
}

