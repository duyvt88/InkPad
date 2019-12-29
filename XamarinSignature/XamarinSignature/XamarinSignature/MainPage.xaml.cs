using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinSignature
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var strClass = (StrokeClass)BindingContext;
            if(strClass != null && !string.IsNullOrEmpty(strClass.name))
            {
                signatureView.Strokes = strClass.stroke;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var strokes = signatureView.Strokes;
            var strClass = new StrokeClass() { 
                name = "Image " + DateTime.Now.ToString("MMddyyyy hh:mm:ss"),
                stroke = strokes
            };
            App._lstStroke.Add(strClass);
        }
    }
}
