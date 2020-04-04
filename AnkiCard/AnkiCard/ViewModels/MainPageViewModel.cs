using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnkiCard.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigatedAware
    {
        private readonly INavigationService _navigationService;

        //public MainPageViewModel(INavigationService navigationService)
        //{
        //    this._navigationService = navigationService;
        //}
        private string _titleMain = "Hello MainPage2";
        public string TitleMain
        {
            get => _titleMain;
            set => SetProperty(ref _titleMain, value);
        }

        public MainPageViewModel()
        {

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}
