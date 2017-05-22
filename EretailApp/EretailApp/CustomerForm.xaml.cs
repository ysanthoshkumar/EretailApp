using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp
{
    public partial class CustomerForm : ContentPage
    {
        List<ProductModel> ll = new List<ProductModel>
        {
              new ProductModel
           {
        name="Shirt",
        Dept="PepiJeans",
                category="Mens",
                Icon="ic_user.png",
         },
           new ProductModel
           {
                name="Jeans",
                Dept="PepiJeans",
                category="Mens",
                Icon="ic_user.png",

           }
           ,

             new ProductModel
           {
               name="T-Shirt",
                Dept="Pan America",
                category="Womens",
                Icon="ic_user.png",

           }
             ,
                 new ProductModel
           {
               name=" Round Neck T-Shirt",
                Dept="Us Polo",
                category="Kids",
                Icon="ic_user.png",

           }
                 ,

                       new ProductModel
           {
               name="Gap-TShirt ",
                Dept="Lives",
                category="Branded Shirts",
                Icon="ic_user.png",

           }

,

        };




        public CustomerForm()
        {
            InitializeComponent();
            CustmorList.ItemsSource = ll;
        }


        public void btnclick(Object o, EventArgs e)
        {

            String str = searchvalue.Text;
            IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.name.Contains(str));
            CustmorList.ItemsSource = searchresult;

            //if (str.Equals(""))
            //{
            //    ll.Clear();
            //}

        }

        public void AddCustmor(Object o, EventArgs e)
        {
            Navigation.PushModalAsync(new AddCustomer());
        }



    }
}
