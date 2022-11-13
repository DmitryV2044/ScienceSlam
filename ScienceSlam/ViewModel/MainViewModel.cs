using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ScienceSlam
{
	public partial class MainViewModel : ObservableObject
	{
		public MainViewModel()
		{
		}

		[RelayCommand]
		async Task MoveToRegistrationPage()
		{
			await Shell.Current.GoToAsync("..");
		}

        [RelayCommand]
        async Task MoveToCurrentEventPage()
        {
            await Shell.Current.GoToAsync(nameof(CurrentEventPage));
        }


    }
}

