using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HPlusSports
{
    public partial class ProductDetail : ContentPage
    {
        public ProductDetail()
        {
            InitializeComponent();
        }
        public ProductDetail(Services.Product product)
        {
            InitializeComponent();
            BindingContext = product;
        }
    }
}
