using Android.App;
using Android.OS;
using DuplicateAppStartViewModel.Core;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace DuplicateAppStartViewModel.Droid
{
    [MvxActivityPresentation]
    [Activity(Label = "DuplicateAppStartViewModel", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
        }
    }
}
