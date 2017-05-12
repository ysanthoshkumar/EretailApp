using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp
{
    public partial class LoginForm : ContentPage
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public void HomePage(Object o, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}
