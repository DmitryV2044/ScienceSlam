using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace ScienceSlam
{
	public partial class CurrentEventPageAltModel : ObservableObject
	{
		[RelayCommand]
        async Task MoveToMainPage()
        {
            await Shell.Current.GoToAsync(nameof(VotePage));
        }

    }
}

