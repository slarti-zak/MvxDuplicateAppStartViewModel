# MvxDuplicateAppStartViewModel

Sample project showing that the first viewmodel ist created twice on android.

## Reproduce

Start the App on Android. The first view will show how many times the viewmodel was instantiated.

Or

Set a breakpoint in the MainViewModel constructor.

## Stacktrace

### The first viewmodel will be created by the Activity#OnCreate

```cs
MvvmCross.IoC.MvxIoCProvider.IoCConstruct(System.RuntimeType type = {DuplicateAppStartViewModel.Core.MainViewModel}) in C:/projects/mvvmcross/MvvmCross/IoC/MvxIoCProvider.cs:148
MvvmCross.ViewModels.MvxDefaultViewModelLocator.Load(System.RuntimeType viewModelType = {DuplicateAppStartViewModel.Core.MainViewModel}, MvvmCross.ViewModels.MvxBundle parameterValues = {MvvmCross.ViewModels.MvxBundle}, MvvmCross.ViewModels.IMvxBundle savedState = (null), MvvmCross.Navigation.EventArguments.IMvxNavigateEventArgs navigationArgs = (null)) in C:/projects/mvvmcross/MvvmCross/ViewModels/MvxDefaultViewModelLocator.cs:56
MvvmCross.ViewModels.MvxViewModelLoader.LoadViewModel(MvvmCross.ViewModels.MvxViewModelRequest request = {MvvmCross.ViewModels.MvxViewModelRequest}, MvvmCross.ViewModels.IMvxBundle savedState = (null), MvvmCross.Navigation.EventArguments.IMvxNavigateEventArgs navigationArgs = (null)) in C:/projects/mvvmcross/MvvmCross/ViewModels/MvxViewModelLoader.cs:73
MvvmCross.Platforms.Android.Views.MvxAndroidViewsContainer.DirectLoad(MvvmCross.ViewModels.IMvxBundle savedState = (null), System.RuntimeType viewModelTypeHint = {DuplicateAppStartViewModel.Core.MainViewModel}) in C:/projects/mvvmcross/MvvmCross/Platforms/Android/Views/MvxAndroidViewsContainer.cs:81
MvvmCross.Platforms.Android.Views.MvxAndroidViewsContainer.Load(Android.Content.Intent intent = {Intent { flg=0x10000000 cmp=eu.salt_and_pepper.DuplicateAppStartViewModel/md5745b08b8216c6d4cdf243b8c8024ded8.MainActivity }}, MvvmCross.ViewModels.IMvxBundle savedState = (null), System.RuntimeType viewModelTypeHint = {DuplicateAppStartViewModel.Core.MainViewModel}) in C:/projects/mvvmcross/MvvmCross/Platforms/Android/Views/MvxAndroidViewsContainer.cs:52
MvvmCross.Platforms.Android.Views.MvxActivityViewExtensions.LoadViewModel(DuplicateAppStartViewModel.Droid.MainActivity androidView = {md5745b08b8216c6d4cdf243b8c8024ded8.MainActivity@1c1b20a}, MvvmCross.ViewModels.IMvxBundle savedState = (null)) in C:/projects/mvvmcross/MvvmCross/Platforms/Android/Views/MvxActivityViewExtensions.cs:139
MvvmCross.Platforms.Android.Views.MvxActivityViewExtensions.() in C:/projects/mvvmcross/MvvmCross/Platforms/Android/Views/MvxActivityViewExtensions.cs:47
MvvmCross.Views.MvxViewExtensions.OnViewCreate(DuplicateAppStartViewModel.Droid.MainActivity view = {md5745b08b8216c6d4cdf243b8c8024ded8.MainActivity@1c1b20a}, System.Func<MvvmCross.ViewModels.IMvxViewModel> viewModelLoader = {System.Func<MvvmCross.ViewModels.IMvxViewModel>}) in C:/projects/mvvmcross/MvvmCross/Views/MvxViewExtensions.cs:24
MvvmCross.Platforms.Android.Views.MvxActivityViewExtensions.OnViewCreate(DuplicateAppStartViewModel.Droid.MainActivity androidView = {md5745b08b8216c6d4cdf243b8c8024ded8.MainActivity@1c1b20a}, Android.OS.Bundle bundle = (null)) in C:/projects/mvvmcross/MvvmCross/Platforms/Android/Views/MvxActivityViewExtensions.cs:47
MvvmCross.Platforms.Android.Views.MvxActivityAdapter.EventSourceOnCreateCalled(DuplicateAppStartViewModel.Droid.MainActivity sender = {md5745b08b8216c6d4cdf243b8c8024ded8.MainActivity@1c1b20a}, MvvmCross.Base.MvxValueEventArgs<Android.OS.Bundle> eventArgs = {MvvmCross.Base.MvxValueEventArgs<Android.OS.Bundle>}) in C:/projects/mvvmcross/MvvmCross/Platforms/Android/Views/MvxActivityAdapter.cs:76
MvvmCross.Base.MvxDelegateExtensions.Raise<Android.OS.Bundle>(System.EventHandler<MvvmCross.Base.MvxValueEventArgs<Android.OS.Bundle>> eventHandler = {System.EventHandler<MvvmCross.Base.MvxValueEventArgs<Android.OS.Bundle>>}, DuplicateAppStartViewModel.Droid.MainActivity sender = {md5745b08b8216c6d4cdf243b8c8024ded8.MainActivity@1c1b20a}, Android.OS.Bundle value = (null)) in C:/projects/mvvmcross/MvvmCross/Base/MvxDelegateExtensions.cs:18
MvvmCross.Platforms.Android.Views.Base.MvxEventSourceActivity.OnCreate(Android.OS.Bundle bundle = (null)) in C:/projects/mvvmcross/MvvmCross/Platforms/Android/Views/Base/MvxEventSourceActivity.cs:32
MvvmCross.Platforms.Android.Views.MvxActivity.OnCreate(Android.OS.Bundle bundle = (null)) in C:/projects/mvvmcross/MvvmCross/Platforms/Android/Views/MvxActivity.cs:115
DuplicateAppStartViewModel.Droid.MainActivity.OnCreate(Android.OS.Bundle bundle = (null)) in
```

### The second viewmodel will be created by the navigation service

```cs
MvvmCross.IoC.MvxIoCContainer.IoCConstruct(System.RuntimeType type = {DuplicateAppStartViewModel.Core.MainViewModel}, System.Reflection.MonoCMethod constructor = {Void .ctor()}, object[] arguments = {object[0]}) in C:/projects/mvvmcross/MvvmCross/IoC/MvxIoCContainer.cs:422
MvvmCross.IoC.MvxIoCContainer.IoCConstruct(System.RuntimeType type = {DuplicateAppStartViewModel.Core.MainViewModel}, System.Collections.Generic.IDictionary<string,object> arguments = (null)) in C:/projects/mvvmcross/MvvmCross/IoC/MvxIoCContainer.cs:414
MvvmCross.IoC.MvxIoCContainer.IoCConstruct(System.RuntimeType type = {DuplicateAppStartViewModel.Core.MainViewModel}) in C:/projects/mvvmcross/MvvmCross/IoC/MvxIoCContainer.cs:362
MvvmCross.IoC.MvxIoCProvider.IoCConstruct(System.RuntimeType type = {DuplicateAppStartViewModel.Core.MainViewModel}) in C:/projects/mvvmcross/MvvmCross/IoC/MvxIoCProvider.cs:148
MvvmCross.ViewModels.MvxDefaultViewModelLocator.Load(System.RuntimeType viewModelType = {DuplicateAppStartViewModel.Core.MainViewModel}, MvvmCross.ViewModels.MvxBundle parameterValues = {MvvmCross.ViewModels.MvxBundle}, MvvmCross.ViewModels.IMvxBundle savedState = (null), MvvmCross.Navigation.EventArguments.IMvxNavigateEventArgs navigationArgs = (null)) in C:/projects/mvvmcross/MvvmCross/ViewModels/MvxDefaultViewModelLocator.cs:56
MvvmCross.ViewModels.MvxViewModelLoader.LoadViewModel(MvvmCross.ViewModels.MvxViewModelInstanceRequest request = {MvvmCross.ViewModels.MvxViewModelInstanceRequest}, MvvmCross.ViewModels.IMvxBundle savedState = (null), MvvmCross.Navigation.EventArguments.IMvxNavigateEventArgs navigationArgs = (null)) in C:/projects/mvvmcross/MvvmCross/ViewModels/MvxViewModelLoader.cs:73
MvvmCross.Navigation.MvxNavigationService.Navigate() in C:/projects/mvvmcross/MvvmCross/Navigation/MvxNavigationService.cs:394
System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Start<MvvmCross.Navigation.MvxNavigationService.<Navigate>d__53>(MvvmCross.Navigation.MvxNavigationService stateMachine = {MvvmCross.Navigation.MvxNavigationService}) in 
MvvmCross.Navigation.MvxNavigationService.Navigate(System.RuntimeType viewModelType = {DuplicateAppStartViewModel.Core.MainViewModel}, MvvmCross.ViewModels.IMvxBundle presentationBundle = (null), System.Threading.CancellationToken cancellationToken = IsCancellationRequested = False) in 
MvvmCross.Navigation.MvxNavigationService.Navigate<DuplicateAppStartViewModel.Core.MainViewModel>(MvvmCross.ViewModels.IMvxBundle presentationBundle = (null), System.Threading.CancellationToken cancellationToken = IsCancellationRequested = False) in C:/projects/mvvmcross/MvvmCross/Navigation/MvxNavigationService.cs:432
MvvmCross.ViewModels.MvxAppStart<DuplicateAppStartViewModel.Core.MainViewModel>.NavigateToFirstViewModel() in C:/projects/mvvmcross/MvvmCross/ViewModels/MvxAppStart.cs:79
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<MvvmCross.ViewModels.MvxAppStart<DuplicateAppStartViewModel.Core.MainViewModel>.<NavigateToFirstViewModel>d__1>(MvvmCross.ViewModels.MvxAppStart`1 stateMachine = {MvvmCross.ViewModels.MvxAppStart`1}) in 
MvvmCross.ViewModels.MvxAppStart<DuplicateAppStartViewModel.Core.MainViewModel>.NavigateToFirstViewModel(object hint = (null)) in 
MvvmCross.ViewModels.MvxAppStart.StartAsync() in C:/projects/mvvmcross/MvvmCross/ViewModels/MvxAppStart.cs:43
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<MvvmCross.ViewModels.MvxAppStart.<StartAsync>d__5>(MvvmCross.ViewModels.MvxAppStart stateMachine = {MvvmCross.ViewModels.MvxAppStart}) in 
MvvmCross.ViewModels.MvxAppStart.StartAsync(object hint = (null)) in 
MvvmCross.ViewModels.MvxAppStart.Start(object hint = (null)) in C:/projects/mvvmcross/MvvmCross/ViewModels/MvxAppStart.cs:28
MvvmCross.Platforms.Android.Views.MvxActivity.RunAppStart(Android.OS.Bundle bundle = (null)) in C:/projects/mvvmcross/MvvmCross/Platforms/Android/Views/MvxActivity.cs:128
MvvmCross.Platforms.Android.Views.MvxActivity.OnCreate(Android.OS.Bundle bundle = (null)) in C:/projects/mvvmcross/MvvmCross/Platforms/Android/Views/MvxActivity.cs:120
```