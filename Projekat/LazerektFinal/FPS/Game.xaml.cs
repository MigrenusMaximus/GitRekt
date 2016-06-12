using FPS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Lazerekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Game : Page
    {
        public Game() {
            this.InitializeComponent();
            btnOptions.IsEnabled = false;
        }
        private void btnPlay_Click(object sender, RoutedEventArgs e) {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(MainPage));
        }
        private void btnCommunity_Click(object sender, RoutedEventArgs e) {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(CommunityHub));
        }
        private void btnOptions_Click(object sender, RoutedEventArgs e) {
            
        }
    }
}
