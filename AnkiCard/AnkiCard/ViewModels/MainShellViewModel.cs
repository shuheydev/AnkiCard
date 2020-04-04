using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnkiCard.ViewModels
{
    public class MainShellViewModel : BindableBase, INavigatedAware
    {
        private readonly INavigationService _navigationService;

        public MainShellViewModel(INavigationService navigationService)
        {
            this._navigationService = navigationService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }


        private string _titleShell = "Hello Shell";
        public string TitleShell
        {
            get => _titleShell;
            set => SetProperty(ref _titleShell, value);
        }


    }
}
