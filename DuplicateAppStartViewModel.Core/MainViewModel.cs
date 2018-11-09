using System;
using System.Threading;
using MvvmCross.ViewModels;

namespace DuplicateAppStartViewModel.Core
{
    public class MainViewModel : MvxViewModel
    {
        private static event EventHandler CounterChanged;
        private static int _constructorCounter = 0;

        public int Counter => _constructorCounter;

        public MainViewModel()
        {
            CounterChanged += OnCounterChanged;
            NextCounterValue();
        }

        private void OnCounterChanged(object sender, EventArgs e)
        {
            RaisePropertyChanged(nameof(Counter));
        }

        private static int NextCounterValue()
        {
            var next = Interlocked.Increment(ref _constructorCounter);
            CounterChanged?.Invoke(null, null);
            return next;
        }

        public override void ViewDestroy(bool viewFinishing = true)
        {
            if (viewFinishing)
            {
                CounterChanged -= OnCounterChanged;
            }
            base.ViewDestroy(viewFinishing);
        }
    }
}
