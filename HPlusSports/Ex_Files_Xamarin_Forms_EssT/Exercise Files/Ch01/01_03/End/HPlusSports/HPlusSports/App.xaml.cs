﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HPlusSports
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Services.ProductService.LoadWishList();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Services.ProductService.SaveWishList();
        }

        protected override void OnResume()
        {
            Services.ProductService.LoadWishList();
        }
    }
}
