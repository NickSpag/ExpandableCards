using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace ExpandableCardExample.ViewModels
{
    public class CardsPageViewModel : BaseViewModel
    {
        private bool _hasNotification;

        public bool HasNotification
        {
            get => _hasNotification;
            set
            {
                SetProperty(ref _hasNotification, value);
            }
        }

        public ICommand ToggleNotificationCommand { get; }

        public CardsPageViewModel()
        {
            Title = "Cards";

            ToggleNotificationCommand = new Command(ToggleNotification);
        }

        private void ToggleNotification(object obj)
        {
            HasNotification = !HasNotification;
        }
    }
}