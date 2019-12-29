using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSignature
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPage : ContentPage
    {
        public NewPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var strClass = (StrokeClass)BindingContext;
            if (strClass != null && !string.IsNullOrEmpty(strClass.name))
            {
                signatureView.Strokes = strClass.stroke;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var strokes = signatureView.Strokes;
            var strClass = new StrokeClass()
            {
                name = "Image " + DateTime.Now.ToString("MMddyyyy hh:mm:ss"),
                stroke = strokes
            };
            App._lstStroke.Add(strClass);
        }
    }
}