using System;
using System.Collections.Generic;
using HPlusSports.Services;
using Xamarin.Forms;

namespace HPlusSports
{
    [Xamarin.Forms.Xaml.XamlCompilation(Xamarin.Forms.Xaml.XamlCompilationOptions.Skip)]
    public partial class OrderForm : TabbedPage
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(Order target)
        {
            InitializeComponent();
            BindingContext = target;
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            Order o = BindingContext as Order;
            //Device.RuntimePlatform == Device.iOS

            DisplayAlert("Order Placed", $"Order placed for {o.Quantity} of {o.ProductName} and you rated it {o.Rating}.", "OK");
        }
    }
}
