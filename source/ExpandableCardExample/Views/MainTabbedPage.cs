using System;
using Xamarin.Forms;
using ExpandableCardExample.Views;
namespace ExpandableCardExample
{
    public class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {

            Children.Add(CardsPage.CreateInNavigationPage());

        }
    }
}
