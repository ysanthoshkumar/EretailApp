using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp
{
    public partial class ProductConfig : ContentPage
    {
        public ProductConfig()
        {
            InitializeComponent();


        }

        public void back(Object o, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}
