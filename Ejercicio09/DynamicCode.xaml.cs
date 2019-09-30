using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio09
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicCode : ContentPage
    {
        bool originalStyle = true;
        public DynamicCode()
        {
            InitializeComponent();

            var blueSearchBarStyle = new Style(typeof(SearchBar)) {
                Setters = {
                    new Setter { Property = SearchBar.TextColorProperty, Value = Color.Blue }
                }
            };      

            var searchBar1 = new SearchBar { Placeholder = "These SearchBar controls" };
            searchBar1.SetDynamicResource(VisualElement.StyleProperty, "searchBarStyle");

            Resources = new ResourceDictionary();
            Resources.Add("blueSearchBarStyle", blueSearchBarStyle);
            Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];

            Content = new StackLayout
            {
                Children = { searchBar1}
            };

        }

        void Button_Clicked(object sender, EventArgs e)
        {
            if (originalStyle)
            {
                Resources["searchBarStyle"] = Resources["greenSearchBarStyle"];
                originalStyle = false;
            }
            else
            {
                Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
                originalStyle = true;
            }
        }
    }
}
