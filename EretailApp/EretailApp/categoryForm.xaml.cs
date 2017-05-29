using EretailApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp
{
    public partial class categoryForm : ContentPage
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

  public categoryForm()
        {
            InitializeComponent();
            categoryList.ItemsSource = ll;
        }


        public void SearchCategoryclick(Object o, EventArgs e)
        {

            String str = searchcategory.Text;
            IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.name.Contains(str));
            categoryList.ItemsSource = searchresult;

          

        }

        public void ADDCategory(Object o, EventArgs e)
        {
            // Navigation.PushModalAsync(new AddCategoryForm());
            categoryTitle.Text = "Category";
            CreateCategory.IsVisible = true;
        }


        public void ADDCategory1(Object o, EventArgs e)
        {
           // Navigation.PushModalAsync(new AddCategoryForm());
            //CreateCategory.IsVisible = true;
        }
    }
}
