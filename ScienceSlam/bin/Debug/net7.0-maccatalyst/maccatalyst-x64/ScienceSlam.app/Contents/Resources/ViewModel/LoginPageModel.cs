using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace ScienceSlam
{
	public partial class LoginPageModel : ObservableObject
	{
        [ObservableProperty]
        private string _login;

        [ObservableProperty]
        private string _password;


        [RelayCommand]
        async Task MoveToMainPage()
        {
            
            await Shell.Current.GoToAsync($"..");
        }

    }
}

