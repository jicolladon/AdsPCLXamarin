using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AdsPCL
{
    public class ExamplePage : ContentPage
    {
        public ExamplePage()
        {
            var Title = new Label
            {
                Text = "Advertising Example for Cross Platform",
            };

            var myBanner = new MyBanner();

            Content = new StackLayout
            {
                Children = { Title, myBanner }
            };
        }
    }
}
