using DuplicateAppStartViewModel.Core;
using MvvmCross.ViewModels;

namespace DuplicateAppStartViewModel
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            RegisterAppStart<MainViewModel>();
        }
    }
}
