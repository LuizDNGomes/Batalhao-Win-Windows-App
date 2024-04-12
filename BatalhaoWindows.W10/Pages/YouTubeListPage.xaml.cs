//---------------------------------------------------------------------------
//
// <copyright file="YouTubeListPage.xaml.cs" company="Microsoft">
//    Copyright (C) 2015 by Microsoft Corporation.  All rights reserved.
// </copyright>
//
// <createdOn>12/17/2016 7:40:58 PM</createdOn>
//
//---------------------------------------------------------------------------

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml;
using AppStudio.DataProviders.YouTube;
using BatalhaoWindows.Sections;
using BatalhaoWindows.ViewModels;
using AppStudio.Uwp;

namespace BatalhaoWindows.Pages
{
    public sealed partial class YouTubeListPage : Page
    {
	    public ListViewModel ViewModel { get; set; }
        public YouTubeListPage()
        {
			ViewModel = ViewModelFactory.NewList(new YouTubeSection());

            this.InitializeComponent();
			commandBar.DataContext = ViewModel;
			NavigationCacheMode = NavigationCacheMode.Enabled;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
			ShellPage.Current.ShellControl.SelectItem("247b555f-3bd4-4e74-8c8f-7dcdf2c7ee46");
			ShellPage.Current.ShellControl.SetCommandBar(commandBar);
			if (e.NavigationMode == NavigationMode.New)
            {			
				await this.ViewModel.LoadDataAsync();
                this.ScrollToTop();
			}			
            base.OnNavigatedTo(e);
        }

    }
}
