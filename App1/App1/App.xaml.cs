using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1 {
    public partial class App : Application {
        public App() {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage()) {
                //BarBackgroundColor = Color.FromHex("0xeeff000000")
            };
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


        //protected override void OnAppLinkRequestReceived(Uri uri) {

        //    var data = uri.ToString().ToLowerInvariant();
        //    //only if deep linking
        //    if (!data.Contains("/session/"))
        //        return;

        //    var id = data.Substring(data.LastIndexOf("/", StringComparison.Ordinal) + 1);

        //    //Navigate based on id here.

        //    base.OnAppLinkRequestReceived(uri);


        //    base.OnAppLinkRequestReceived(uri);
        //}
    }
}
