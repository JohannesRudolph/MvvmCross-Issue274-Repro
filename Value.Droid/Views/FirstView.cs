using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace Value.Droid.Views
{
    [Activity(ScreenOrientation=Android.Content.PM.ScreenOrientation.Landscape)]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}