using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace Value.Droid
{
    [Activity(Label = "Your App Name",  MainLauncher = true, NoHistory = true, Icon = "@drawable/icon", ScreenOrientation=Android.Content.PM.ScreenOrientation.Landscape)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        static int initialized = 1;

        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
            System.Console.WriteLine( "Created splash screen instance " + this.ToString() );

            if (Interlocked.CompareExchange( ref initialized, 0, 1 ) == 0)
                Console.WriteLine( "SplashScreen was already initialized" );
        }
    }
}