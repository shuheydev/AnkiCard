using AnkiCard.ViewModels;
using AnkiCard.Views;
using Prism.Ioc;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnkiCard
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            NavigationService.NavigateAsync(nameof(MainShell));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainShell,MainShellViewModel>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }

        protected override void OnInitialized()
        {
        }
    }
}
