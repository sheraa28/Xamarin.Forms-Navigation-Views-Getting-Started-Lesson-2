﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GettingStarted2.Views;
using GettingStarted2.ViewModels;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GettingStarted2 {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new NavPage(new MainPage());
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
