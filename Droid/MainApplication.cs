using System;
using Android.Runtime;
using MvvmCross.Platforms.Android.Views;
using Android.App;

namespace DuplicateAppStartViewModel.Droid
{
    [Application]
    public class MainApplication : MvxAndroidApplication<DroidSetup, App>
    {
        public MainApplication()
        {
        }

        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}
