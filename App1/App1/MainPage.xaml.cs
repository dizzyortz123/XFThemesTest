using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1 {
    public partial class MainPage : ContentPage {

        private Dictionary<Type, string> Themes =
            new Dictionary<Type, string>() {
                { typeof(Xamarin.Forms.Themes.DarkThemeResources), "Dark" },
                { typeof(Xamarin.Forms.Themes.LightThemeResources), "Light" }
            };


        public ICommand ChangeThemeCmd { get; }
        public ICommand NugetListCmd { get; }


        public List<string> Msgs {
            get;
        }

        public MainPage() {
            InitializeComponent();

            this.ChangeThemeCmd = new Command(() => ChangeTheme());
            this.NugetListCmd = new Command(() => this.Navigation.PushAsync(new NugetListPage()));

            this.Msgs = new List<string>() {
                "After synchonous Subscribe function the subscription is not always ensured",
                "StackExchange.Redis.RedisServerException - MOVED",
                "custom condition within transaction"
            };

            this.BindingContext = this;
        }

        private void ChangeTheme() {
            if (App.Current.Resources == null)
                App.Current.Resources = new ResourceDictionary();

            if (App.Current.Resources.MergedWith == null)
                App.Current.Resources.MergedWith = this.Themes.First().Key;
            else {
                var mw = App.Current.Resources.MergedWith;
                if (mw == this.Themes.First().Key) {
                    mw = this.Themes.Last().Key;
                } else {
                    mw = this.Themes.First().Key;
                }
                App.Current.Resources.MergedWith = mw;
            }
        }

        protected override void OnAppearing() {
            base.OnAppearing();

            var url = $"http://evolve.xamarin.com/session/1";

            var entry = new AppLinkEntry {
                Title = "What ??",
                Description = "What ???",
                AppLinkUri = new Uri(url, UriKind.RelativeOrAbsolute),
                IsLinkActive = true,
                Thumbnail = ImageSource.FromFile("Icon.png")
            };

            entry.KeyValues.Add("contentType", "Session");
            entry.KeyValues.Add("appName", "Evolve16");
            entry.KeyValues.Add("companyName", "Xamarin");

            Application.Current.AppLinks.RegisterLink(entry);
        }
    }
}
