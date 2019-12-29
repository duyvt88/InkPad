using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinSignature
{
    public class StrokeClass
    {
        public string name { get; set; }
        public IEnumerable<IEnumerable<Point>> stroke;
    }

    public partial class App : Application
    {
        //public static string FolderPath { get; private set; }
        public static List<StrokeClass> _lstStroke;

        public App()
        {
            InitializeComponent();
            //FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            _lstStroke = new List<StrokeClass>();
            MainPage = new NavigationPage(new StrokesPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
