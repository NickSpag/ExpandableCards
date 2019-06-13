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

        public static NavigationPage CreateInNavigationPage()
        {
            var page = new CardsPage();

            //if I wanted to hide the bar all together: (keep in mind you'll need to add extra spacing for notch-devices like iPhoneX
            //page.SetValue(NavigationPage.HasNavigationBarProperty, false);

            var navPage = new NavigationPage(page)
            {
                BarTextColor = Color.FromHex("#11BF88"),
                BarBackgroundColor = Color.White,
                IconImageSource = "cardsIcon.png",
                Title = "Cards",
            };

            return navPage;
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