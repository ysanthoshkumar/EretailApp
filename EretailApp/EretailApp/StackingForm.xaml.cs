﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp
{
    public partial class StackingForm : ContentPage
    {

        List<ProductModel> ll = new List<ProductModel>

        {
              new ProductModel
           {
        name="Ean10101",
        Dept="25",
                category="Mens",
                Icon="ic_user.png",
         },
           new ProductModel
           {
                name="Ean10102",
                Dept="30",
                category="Mens",
                Icon="ic_user.png",

           }
           ,

             new ProductModel
           {
               name="Ean10103",
                Dept="40",
                category="Womens",
                Icon="ic_user.png",

           }
             ,
                 new ProductModel
           {
               name="Ean104",
                Dept="50",
                category="Kids",
                Icon="ic_user.png",

           }
                 ,

                       new ProductModel
           {
               name="Ean105 ",
                Dept="60",
                category="Branded Shirts",
                Icon="ic_user.png",

           }

,

        };



        String strSkuCode;
        String strEANCode;
        String strQty;
        String strVariant ;
        String strRemarks;


        public StackingForm()
        {
            InitializeComponent();
        }

        // back nav
        public void back(Object o, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        // Search Sku 

        public void btnclick(Object o, EventArgs e)
        {

            string str = searchsku.Text;
            IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.name.Contains(str));
            SkuList.ItemsSource = searchresult;

            //if (str.Equals(""))
            //{ SkuItemCliscked OnSkuItemSelected
            //    ll.Clear();
            //}

        }

        // Add details to list view 

        public void AddIcon(Object o, EventArgs e)
        {

            SkuListAdd.IsVisible = false;
            SkuSL.IsVisible = false;
            MainlistSl.IsVisible = true;
            SkuListEdit.IsVisible = true;



            strSkuCode = entrysku.Text;
            strEANCode = entryEAN.Text;
            strQty = entryQty.Text;
            strVariant = entrVariants.Text;
            strRemarks = entrRemarks.Text;


            Editentrysku.Text = strSkuCode;
            EditentryEAN.Text = strEANCode;
            EditentryQty.Text = strQty;
            EditentryVariant.Text= strVariant;
            EditentryRemarks.Text = strRemarks;
       

            List<ProductModel> ll = new List<ProductModel>

            {
                  new ProductModel
               {

            Sku =strSkuCode,
        EANCode =strEANCode,
       Qty =strQty,
        Variant =strVariant,
             Remarks =strRemarks,
           
             },
                };


            Mainlist.ItemsSource = ll;
        }

        // Edit detail layout to list view 
        public void EditIcon(Object o, EventArgs e)
        {

            SkuListAdd.IsVisible = false;

            strSkuCode = Editentrysku.Text;
            strEANCode = EditentryEAN.Text;
            strQty = EditentryQty.Text;
            strVariant = EditentryVariant.Text;
            strRemarks = EditentryRemarks.Text;



            entrysku.Text= strSkuCode;
           entryEAN.Text = strEANCode ;
            entryQty.Text = strQty ;
            entrVariants.Text= strVariant ;
           entrRemarks.Text = strRemarks; ;
           

            List<ProductModel> ll = new List<ProductModel>

            {
                  new ProductModel
               {

            Sku =strSkuCode,
              EANCode =strEANCode,
       Qty =strQty,
        Variant =strVariant,
             Remarks =strRemarks,


             },
                };


            Mainlist.ItemsSource = ll;
            MainlistSl.IsVisible = true;


        }









        public void AddDeleteIcon(Object o, EventArgs e)
        {
            entrysku.Text = "";
            entryEAN.Text = "";
            entryQty.Text = "";
            entrVariants.Text = "";
            entrRemarks.Text = "";
            

        }


        public void EditDeleteIcon(Object o, EventArgs e)
        {
            Editentrysku.Text = "";
            EditentryEAN.Text = "";
            EditentryQty.Text = "";
            EditentryVariant.Text = "";
            EditentryRemarks.Text ="";
        }


        public void SkuItemClilcked(Object o, EventArgs e)
        {
            SkuSL.IsVisible = true;

            SkuList.ItemsSource = ll;
        }

        public void EditSkuItemClilcked(Object o, EventArgs e)
        {

            EditSkuSL.IsVisible = true;
            EditSkuList.ItemsSource = ll;
        }




        public void OnSkuItemSelected(Object o, SelectedItemChangedEventArgs e)
        {

            var item = (ProductModel)e.SelectedItem;
            entryEAN.Text = item.name.ToString();
            SkuSL.IsVisible = false;


        }


        public void OnEditSkuItemSelected(Object o, SelectedItemChangedEventArgs e)
        {

            var item = (ProductModel)e.SelectedItem;
            EditentryEAN.Text = item.name.ToString();
            EditSkuSL.IsVisible = false;


        }





        public void MainlistAddIcon(Object o, EventArgs e)
        {
            Editentrysku.Text = strSkuCode;
            EditentryEAN.Text = strEANCode;
            EditentryQty.Text = strQty;
            EditentryVariant.Text = strVariant;
            EditentryRemarks.Text = strRemarks;



            SkuListAdd.IsVisible = true;
            MainlistSl.IsVisible = false;
            SkuListEdit.IsVisible = false;


        }


        public void MainlistDeleteRow(Object o, EventArgs e)
        {
            ll.Clear();
            Mainlist.ItemsSource = ll;
            MainlistSl.IsVisible = false;

        }









    }
}
