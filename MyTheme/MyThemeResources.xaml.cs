using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyTheme {
    public partial class MyThemeResources : ResourceDictionary {
        public MyThemeResources() {
            InitializeComponent();
        }
    }
}
