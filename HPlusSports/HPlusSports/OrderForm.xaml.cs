﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPlusSports.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HPlusSports
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
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
            DisplayAlert("Order placed", $"Order placed for {o.Quantity} of {o.ProductName}", "OK");
        }
    }
}