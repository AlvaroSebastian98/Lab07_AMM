using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio09
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ClassDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ClassDemo());

            };
            DynamicCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicCode());
            };
            DynamicDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicDemo());

            };
            ExplicitCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitCode());

            };
            ExplicitControlCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitControlCode());

            };
            ExplicitControlDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitControlDemo());

            };
            ExplicitDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitDemo());
            };
            GlobalCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GlobalCode());

            };
            GlobalDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GlobalDemo());

            };
            ImplicitCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitCode());

            };
            ImplicitControlDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitControlDemo());

            };
            ImplicitDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitDemo());

            };
            InheritanceCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InheritanceCode());

            };
            InheritanceDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InheritanceDemo());

            };

        }
    }
}
