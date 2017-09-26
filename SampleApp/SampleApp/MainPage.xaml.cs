﻿using SampleApp.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using SampleApp.Samples;

namespace SampleApp
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        ObservableCollection<SelectionItem> Items = new ObservableCollection<SelectionItem>();

        public MainPage()
        {
            AddItems();
            InitializeComponent();

            ItemList.ItemsSource = Items;
        }

        void AddItems()
        {
            Items.Add(new SelectionItem()
            {
                Identifier = 0,
                Title = "Internet",
                Detail = "Generic content loaded from the internet, no additions whatsoever."
            });

            Items.Add(new SelectionItem()
            {
                Identifier = 1,
                Title = "Local Files",
                Detail = "Load local files, by default these are Android Assets, iOS Resources, and files in the root of a UWP solution"
            });

            Items.Add(new SelectionItem()
            {
                Identifier = 2,
                Title = "String Data",
                Detail = "Load a WebView using string data as the source"
            });

            Items.Add(new SelectionItem()
            {
                Identifier = 3,
                Title = "Bindable Source",
                Detail = "Load a WebView with a bound string as its source"
            });

            Items.Add(new SelectionItem()
            {
                Identifier = 4,
                Title = "Navigation Events (Internet)",
                Detail = "Watch and control events on the webview using internet based content"
            });

            Items.Add(new SelectionItem()
            {
                Identifier = 5,
                Title = "Navigation Events (Local)",
                Detail = "Watch and control events on the webview using file based content"
            });

            Items.Add(new SelectionItem()
            {
                Identifier = 6,
                Title = "Navigation Events (String)",
                Detail = "Watch and control events on the webview using string based content"
            });

            Items.Add(new SelectionItem()
            {
                Identifier = 7,
                Title = "Navigating Property",
                Detail = "Monitor when the webview is in a navigating state using the bindable property"
            });

            Items.Add(new SelectionItem()
            {
                Identifier = 8,
                Title = "Javascript",
                Detail = "Check javascript injection, callbacks, and evaluation functions"
            });
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            int i = (e.SelectedItem as SelectionItem).Identifier;

            switch (i)
            {
                case 0:
                    await ((NavigationPage)Application.Current.MainPage).PushAsync(new InternetSample());
                    break;

                case 1:
                    await ((NavigationPage)Application.Current.MainPage).PushAsync(new LocalFileSample());
                    break;

                case 2:
                    await ((NavigationPage)Application.Current.MainPage).PushAsync(new StringDataSample());
                    break;

                case 3:
                    await ((NavigationPage)Application.Current.MainPage).PushAsync(new SourceSwapSample());
                    break;

                case 4:
                    await ((NavigationPage)Application.Current.MainPage).PushAsync(new NavigationEventsSample());
                    break;

                case 5:
                    await ((NavigationPage)Application.Current.MainPage).PushAsync(new NavigationLocalSample());
                    break;

                case 6:
                    await ((NavigationPage)Application.Current.MainPage).PushAsync(new NavigationStringSample());
                    break;

                case 7:
                    await ((NavigationPage)Application.Current.MainPage).PushAsync(new NavigatingEvent());
                    break;

                case 8:
                    await ((NavigationPage)Application.Current.MainPage).PushAsync(new JavascriptSample());
                    break;

                default:
                    break;
            }
        }
    }

}
