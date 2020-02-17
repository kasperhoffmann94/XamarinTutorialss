using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HPlusSports
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetail : ContentPage
    {
        public ProductDetail()
        {
            InitializeComponent();
            Image embeddedImage = new Image { Source = ImageSource.FromResource("HPlusSports.Images.jpg") };
        }

        public ImageSource Image
        {
            get
            {
                return ImageSource.FromResource("HPlusSports.Images.roman.jpg");
            }
        }
    }
}