﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();

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

        public static void SetMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                      new NavigationPage(new App7.TodoList())
                    {
                        Title = "test",

                    },
                }
            };
        }
    }
}

