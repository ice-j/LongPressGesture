using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LongTapRecognition
{
	public class App : Application
	{
		public App ()
		{
            var xamarinLogo = new CustomImage
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 300,
                HeightRequest = 300,
                Source = new Uri("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"),
            };

            xamarinLogo.LongPressed += (sender) => MainPage.DisplayAlert("Success!", "Long Press Recognized!", "OK");

            // The root page of your application
            MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						xamarinLogo
					}
				}
			};

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
