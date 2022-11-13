using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace ScienceSlam
{
	public partial class VotePageModel : ObservableObject
	{
        [ObservableProperty]
        private string _parameterName;

		[RelayCommand]
        async Task MoveToMainPage()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task SendData()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}

