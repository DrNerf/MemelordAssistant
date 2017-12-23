﻿using ServiceLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MemelordAssistant
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel { get; set; }
            = new MainPageViewModel();

        public MainPage()
        {
            this.InitializeComponent();
            DataContext = ViewModel;
            //Task.Delay(2000).ContinueWith((t) => { AdaptiveGrid.ItemsSource = ViewModel.Result; }, TaskScheduler.FromCurrentSynchronizationContext());
            //Task.Factory.StartNew(async () => { await new GiphyProviderAdapter().GetItems(1); });
        }
    }
}