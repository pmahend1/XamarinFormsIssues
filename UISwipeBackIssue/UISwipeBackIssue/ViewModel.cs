using System;
using System.ComponentModel;
using MvvmCross.ViewModels;
using Xamarin.Forms;

namespace UISwipeBackIssue
{
    public class ViewModel : MvxViewModel
    {

        INavigation navigation;
        public ViewModel(INavigation navigation)
        {
            this.navigation = navigation;



            NextCommand = new Command(GoToNextPageAction);
            RaisePropertyChanged(nameof(NextCommand));
        }
        private void GoToNextPageAction()
        {
            Device.BeginInvokeOnMainThread(async () => await navigation.PushAsync(new DummyPage()));
        }

        public Command NextCommand { get; set; }


    }
}
