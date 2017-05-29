using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp
{
    public partial class TaxForm : ContentPage
    {
        List<ProductModel> ll = new List<ProductModel>
        {
              new ProductModel
           {
        name="A",
        Dept="10%",
                category="Mens",
                Icon="ic_user.png",
         },
           new ProductModel
           {
                name="B",
                Dept="20%",
                category="Mens",
                Icon="ic_user.png",

           }
           ,

             new ProductModel
           {
               name="C",
                Dept="30%",
                category="Womens",
                Icon="ic_user.png",

           }
             ,
                 new ProductModel
           {
               name=" D",
                Dept="40%",
                category="Kids",
                Icon="ic_user.png",

           }
                 
                     ,
                 new ProductModel
           {
               name=" D",
                Dept="40%",
                category="Kids",
                Icon="ic_user.png",

           }
                 

                     ,
                 new ProductModel
           {
               name=" D",
                Dept="40%",
                category="Kids",
                Icon="ic_user.png",

           }
                 

                     ,
                 new ProductModel
           {
               name=" D",
                Dept="40%",
                category="Kids",
                Icon="ic_user.png",

           }
                 

                     ,
                 new ProductModel
           {
               name=" D",
                Dept="40%",
                category="Kids",
                Icon="ic_user.png",

           }
                 ,


                       new ProductModel
           {
               name="E ",
                Dept="50%",
                category="Branded Shirts",
                Icon="ic_user.png",

           }
,


        };
        public TaxForm()
        {
            InitializeComponent();
            TaxList.ItemsSource = ll;
        }

        public void SearchTaxclick(Object o, EventArgs e)
        {

            String str = searchTax.Text;
            IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.name.Contains(str));
            TaxList.ItemsSource = searchresult;



        }

        public void AddTax(Object o, EventArgs e)
        {
            // Navigation.PushModalAsync(new AddCategoryForm());
            TaxTitle.Text = "Tax";
            CreateCategory.IsVisible = true;
        }



    }
}