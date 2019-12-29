using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSignature
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StrokesPage : ContentPage
    {
        public StrokesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            listView.ItemsSource = null;
            listView.ItemsSource = App._lstStroke;
        }

        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Navigation.PushAsync(new NewPage
                {
                    BindingContext = e.SelectedItem as StrokeClass
                });
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //new NavigationPage(new MainPage());
            //App.Mainp
            Navigation.PushAsync(new NewPage());
            //Navigation.PushAsync(new NewPage
            //{
            //    BindingContext = new StrokeClass()
            //});
        }
    }
}