using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp
{
    public partial class ProductDetails : ContentPage
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

            public ProductDetails()
        {
            InitializeComponent();

            mylistvi.ItemsSource = ll;

            Mainpicker.Items.Add("Mens");
            Mainpicker.Items.Add("Womens");
            Mainpicker.Items.Add("Kids");


            Deptpicker.Items.Add("PepiJeans");
            Deptpicker.Items.Add("Lives");
            Deptpicker.Items.Add("Us Polo");
            Deptpicker.Items.Add("Pan America");
        }



        private void onselecteditem(Object sender, EventArgs e)
        {

            var name = Mainpicker.Items[Mainpicker.SelectedIndex];
          //  DisplayAlert(name, "SelectedItem", "Okay");
            if (!name.Equals("") || !searchvalue.Text.Equals(""))
            {
                String str = searchvalue.Text;
                //if (!str.Equals(""))
                //{
                    //IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.name.Contains(str) || name1.name.Contains(name));
                    //mylistvi.ItemsSource = searchresult;
               // }

            }
        }

        private void Deptonselecteditem(Object sender, EventArgs e)
        {

            var name = Deptpicker.Items[Deptpicker.SelectedIndex];
            //DisplayAlert(name, "SelectedItem", "Okay");

            //if (!name.Equals(""))
            //{
            //    String str = searchvalue.Text;
            //    IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.name.Contains(str) || name1.name.Contains(name));
            //    mylistvi.ItemsSource = searchresult;
            //}



        }


        public void btnclick(Object o, EventArgs e)
        {

            String str = searchvalue.Text;
            IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.name.Contains(str));
            mylistvi.ItemsSource = searchresult;

            //if (str.Equals(""))
            //{
            //    ll.Clear();
            //}

        }

        //public void back(Object o, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new MainPage());
        //}

        public void AddProduct(Object o, EventArgs e)
        {
            Navigation.PushModalAsync(new ProductConfig());
        }
        public void AddProductTwo(Object o, EventArgs e)
        {
            Navigation.PushModalAsync(new ProductConfig());
        }
    }

}

