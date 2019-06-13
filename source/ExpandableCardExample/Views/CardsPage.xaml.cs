using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExpandableCardExample.ViewModels;

namespace ExpandableCardExample.Views
{
    public partial class CardsPage : ContentPage
    {
        private CardsPageViewModel viewModel;
        private bool _collapsed = true;

        public CardsPage()
        {
            InitializeComponent();

        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext is CardsPageViewModel aboutViewModel)
            {
                viewModel = aboutViewModel;
            }
        }

        private async void Chevron_Clicked(object sender, System.EventArgs e)
        {
            var rotationAnimation = ChevronButton.RelRotateTo(180);
            //todo size animation

            _collapsed = !_collapsed;

            CollapsableContent.IsVisible = !_collapsed;

            //if (_collapsed)
            //{
            //    CollapsableContent.IsVisible =

            //    //hide it
            //    ShowNotificationButton.Text = "Show notification";
            //}
            //else
            //{
            //    ShowNotificationButton.Text = "Hide notification";
            //}

            //viewModel.HasNotification = !viewModel.HasNotification;

            await rotationAnimation;
        }
    }
}