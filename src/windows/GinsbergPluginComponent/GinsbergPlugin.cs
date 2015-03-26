using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace GinsbergPluginComponent
{
    public sealed class ManagedCalls
    {
        public static void ExitApp() 
        {
            System.Diagnostics.Debug.WriteLine("ExitApp Start");
            //Application.Current.Exit();
            //Application.exit(0);
            //Windows.UI.Xaml.Application.Exit();
            //Environment.Exit(0);
            //Application.Current.Shutdown();
            System.Diagnostics.Debug.WriteLine("ExitApp End");
        }

        public int SampleProperty { get; set; }
    }
}

/*
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Info;
using System.Windows.Controls.Primitives;
using System.Diagnostics;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System.Windows.Threading;

namespace WPCordovaClassLib.Cordova.Commands
{
    /// <summary>
    /// Listens for changes to the state of the battery on the device.
    /// Currently only the "isPlugged" parameter available via native APIs.
    /// </summary>
    public class SplashScreen : BaseCommand
    {
        private Popup popup;

        // Time until we dismiss the splashscreen
        private int prefDelay = 3000;

        // Whether we hide it by default
        private bool prefAutoHide = true;

        // Path to image to use
        private string prefImagePath = "SplashScreenImage.jpg";

        // static because autodismiss is only ever applied once, at app launch
        // subsequent page loads should not cause the SplashScreen to be shown.
        private static bool WasShown = false;

        public SplashScreen()
        {
            LoadConfigPrefs();

            Image SplashScreen = new Image()
            {
                Height = Application.Current.Host.Content.ActualHeight,
                Width = Application.Current.Host.Content.ActualWidth,
                Stretch = Stretch.Fill
            };

            Uri imagePath = new Uri(prefImagePath, UriKind.RelativeOrAbsolute);
            var imageResource = Application.GetResourceStream(imagePath);
            if (imageResource != null)
            {
                BitmapImage splash_image = new BitmapImage();
                splash_image.SetSource(imageResource.Stream);
                SplashScreen.Source = splash_image;
            }

            // Instansiate the popup and set the Child property of Popup to SplashScreen
            popup = new Popup()
            {
                IsOpen = false,
                Child = SplashScreen,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Center

            };
        }

        public override void OnInit()
        {
            // we only want to autoload on the first page load.
            // but OnInit is called for every page load.
            if (!SplashScreen.WasShown)
            {
                SplashScreen.WasShown = true;
                show();
            }
        }

        private void LoadConfigPrefs()
        {
            StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("config.xml", UriKind.Relative));
            if (streamInfo != null)
            {
                using (StreamReader sr = new StreamReader(streamInfo.Stream))
                {
                    //This will Read Keys Collection for the xml file
                    XDocument configFile = XDocument.Parse(sr.ReadToEnd());

                    string configAutoHide = configFile.Descendants()
                                        .Where(x => (string)x.Attribute("name") == "AutoHideSplashScreen")
                                        .Select(x => (string)x.Attribute("value"))
                                        .FirstOrDefault();

                    bool bVal;
                    prefAutoHide = bool.TryParse(configAutoHide, out bVal) ? bVal : prefAutoHide;

                    string configDelay = configFile.Descendants()
                                      .Where(x => (string)x.Attribute("name") == "SplashScreenDelay")
                                      .Select(x => (string)x.Attribute("value"))
                                      .FirstOrDefault();
                    int nVal;
                    prefDelay = int.TryParse(configDelay, out nVal) ? nVal : prefDelay;

                    string configImage = configFile.Descendants()
                                        .Where(x => (string)x.Attribute("name") == "SplashScreen")
                                        .Select(x => (string)x.Attribute("value"))
                                        .FirstOrDefault();

                    if (!String.IsNullOrEmpty(configImage))
                    {
                        prefImagePath = configImage;
                    }
                }
            }
        }

        public void show(string options = null)
        {

            if (!popup.IsOpen)
            {
                Deployment.Current.Dispatcher.BeginInvoke(() =>
                {
                    popup.Child.Opacity = 0;

                    Storyboard story = new Storyboard();
                    DoubleAnimation animation = new DoubleAnimation()
                    {
                        From = 0.0,
                        To = 1.0,
                        Duration = new Duration(TimeSpan.FromSeconds(0.2))
                    };

                    Storyboard.SetTarget(animation, popup.Child);
                    Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
                    story.Children.Add(animation);

                    story.Begin();

                    popup.IsOpen = true;

                    if (prefAutoHide)
                    {
                        StartAutoHideTimer();
                    }
                });
            }
        }

        public void hide(string options = null)
        {
            if (popup.IsOpen)
            {
                Deployment.Current.Dispatcher.BeginInvoke(() =>
                {

                    popup.Child.Opacity = 1.0;

                    Storyboard story = new Storyboard();
                    DoubleAnimation animation = new DoubleAnimation()
                    {
                        From = 1.0,
                        To = 0.0,
                        Duration = new Duration(TimeSpan.FromSeconds(0.4))
                    };

                    Storyboard.SetTarget(animation, popup.Child);
                    Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
                    story.Children.Add(animation);
                    story.Completed += (object sender, EventArgs e) =>
                    {
                        popup.IsOpen = false;
                    };
                    story.Begin();
                });
            }
        }

        private void StartAutoHideTimer()
        {
            var timer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(prefDelay) };
            timer.Tick += (object sender, EventArgs e) =>
            {
                hide();
                timer.Stop();
            };
            timer.Start();
        }
    }
}

*/