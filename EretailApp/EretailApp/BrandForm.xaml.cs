using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp
{
    public partial class BrandForm : ContentPage
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




        public BrandForm()
        {
            InitializeComponent();
            BrandList.ItemsSource = ll;
        }

        public void SearchBrandclick(Object o, EventArgs e)
        {

            String str = searchBrand.Text;
            IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.name.Contains(str));
            BrandList.ItemsSource = searchresult;



        }

        public void AddBrand(Object o, EventArgs e)
        {
            // Navigation.PushModalAsync(new AddCategoryForm());
               CreateCategory.IsVisible = true;
            BrandTitle.Text = "Brand";
        }



    }
}
