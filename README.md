# MvxDuplicateAppStartViewModel

Sample project showing that the first viewmodel ist created twice on android.

## Reproduce

Start the App on Android. The first view will show how many times the viewmodel was instantiated.

Or

Set a breakpoint in the MainViewModel constructor.

## Stacktrace

- he first viewmodel will be created by the activity: 

```cs
 MvvmCross.Platforms.Android.Views.Base.MvxEventSourceActivity.OnCreate(Android.OS.Bundle bundle = (null)) in C:/projects/mvvmcross/MvvmCross/Platforms/Android/Views/Base/MvxEventSourceActivity.cs:32
```

- the second viewmodel will be created by the navigation service:

```cs
MvvmCross.ViewModels.MvxViewModelLoader.LoadViewModel(MvvmCross.ViewModels.MvxViewModelInstanceRequest request = {MvvmCross.ViewModels.MvxViewModelInstanceRequest}, MvvmCross.ViewModels.IMvxBundle savedState = (null), MvvmCross.Navigation.EventArguments.IMvxNavigateEventArgs navigationArgs = (null)) in C:/projects/mvvmcross/MvvmCross/ViewModels/MvxViewModelLoader.cs:73
MvvmCross.Navigation.MvxNavigationService.Navigate() in C:/projects/mvvmcross/MvvmCross/Navigation/MvxNavigationService.cs:394
```