using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EretailApp.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Setup : ContentPage
    {
        List<ProductModel> lm = new List<ProductModel>();
        List<ProductModel> ll = new List<ProductModel>
        {
            new ProductModel
           {
        name="Telugu",
        PaymentMode="Cash",

         },
           new ProductModel
           {
                name="Jeans",
                 PaymentMode="Card",


           }
           ,

             new ProductModel
           {
               name="English",
                PaymentMode="Credit",


           }
             ,
                 new ProductModel
           {
               name="Hindi",
                PaymentMode="Cheque",


           }
                 ,

                       new ProductModel
           {
               name="Gap-TShirt ",
                PaymentMode="Cash",

           }

,

        };



        public Setup()
        {
            InitializeComponent();
            // languages 
            LangPicker.Items.Add("Telugu");
            LangPicker.Items.Add("English");
            LangPicker.Items.Add("Hindi");

            // paymentModes

            //PaymentModePicker.Items.Add("Cash");
            //PaymentModePicker.Items.Add("Card");
            //PaymentModePicker.Items.Add("Credit");
            //PaymentModePicker.Items.Add("Cheque");

        }


        public void back(Object o, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
            // LangList.ItemsSource = ll;
        }


        public void ChooseLang(Object o, EventArgs e)
        {

            var language = LangPicker.Items[LangPicker.SelectedIndex];
        }


        public void swcard(Object o, ToggledEventArgs e)
        {


            if (e.Value.ToString().Equals("True"))
            {
                //swcard.Text = "ON";



            }

            else
            {
                //swcard.Text = "OFF";
            }

        }


        public void btnpayment(Object o, EventArgs e)
        {
            PaymentList.ItemsSource = ll;
            selectPaymentList.ItemsSource = lm;
            paymentlistsl.IsVisible = true;
            selectpaymentlistsl.IsVisible = false;
       
        }

        public void OnPaymentModeSelected(Object o, SelectedItemChangedEventArgs e)
        {


            var item = (ProductModel)e.SelectedItem;
           // paybtn.Text = item.PaymentMode.ToString();
            //item.IsOwned.ToString();
           
            paymentlistsl.IsVisible = false;

      }

      public void savepaylist(Object o, EventArgs e)
        {
            lm.Clear();
           
            PaymentList.ItemsSource = ll;
            foreach (ProductModel pm in ll)
            {
      lm.Add(pm);
          }
           
            selectPaymentList.ItemsSource = lm;

            selectpaymentlistsl.IsVisible = true;
            paymentlistsl.IsVisible = false;


        }




        //public void ChoosePayment(Object o, EventArgs e)
        //{

       // savepaylist

        //    var payment = PaymentModePicker.Items[PaymentModePicker.SelectedIndex];
        //}

        //void EnableSave(object sender, ToggledEventArgs e)
        //{

        //    //  if (e.Value.ToString().Equals("True"))
        //    //    {
        //    //        swcard.Text = "ON";


        //    //    }
        //    //    else
        //    //    {
        //    //        swcard.Text = "OFF";
        //    //    }



        //}



    }
}