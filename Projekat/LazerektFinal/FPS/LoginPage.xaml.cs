using FPS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Lazerekt {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page {
        private bool inAuth = false;
        public LoginPage() {
            inAuth = false;
            this.InitializeComponent();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e) {
            if (textBox.Text == "" || passwordBox.Password == "")
                return;

            if (inAuth)
                return;

            inAuth = true;
/*
            string url = "http://lazerektapi.azurewebsites.net/lazerekt/login/" + textBox.Text + ":" + passwordBox.Password;
            url = "http://lazerektapi.azurewebsites.net/lazerekt/login/testuser:testpass";

            HttpWebRequest client = (HttpWebRequest) WebRequest.Create(url);
            //client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            string responseText = ":'(";

            try {
                WebResponse responseMsg = await client.GetResponseAsync();
                StreamReader loResponseStream = new StreamReader(responseMsg.GetResponseStream(), Encoding.GetEncoding("UTF8"));
                responseText = loResponseStream.ReadToEnd();
            } catch(HttpRequestException ex) {
                Debug.WriteLine(ex.ToString());
            } catch(System.Net.WebException ex) {
                Debug.WriteLine(ex.ToString());
            }


            inAuth = false;

            textBox.Text = responseText;

            return;

            if (responseText == "invalid" || responseText.StartsWith("Err")) {
                textBox.Text = "";
                passwordBox.Password = "";
                return;
            }
*/
            

            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(Game));
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e) {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(Game));
        }
    }
}
