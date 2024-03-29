﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExpandableCardExample.Services;
using ExpandableCardExample.Views;

namespace ExpandableCardExample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainTabbedPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
