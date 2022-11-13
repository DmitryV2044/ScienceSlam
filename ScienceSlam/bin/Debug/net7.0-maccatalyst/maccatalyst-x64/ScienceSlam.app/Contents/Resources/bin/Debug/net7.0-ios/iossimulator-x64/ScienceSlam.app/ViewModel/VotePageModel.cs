using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace ScienceSlam
{
	public partial class VotePageModel : ObservableObject
	{
        [ObservableProperty]
        private string _parameter;

		[RelayCommand]
        async Task GoToMainPage()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        private void VoteForParam(string s)
        {

        }

        [RelayCommand]
        async Task SendData()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}

