using EretailApp.Menuitem;
using EretailApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EretailApp
{
    public partial class MainPage : MasterDetailPage
    {

        public List<MasterPageItem> menuList
        {

            get; set;

        }

        public List<MasterPageItem> menuList1
        {

            get; set;

        }
        public object DisplayTitle { get; private set; }

        public MainPage()
        {

            InitializeComponent();

            menuList = new List<MasterPageItem>();
            
            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MasterPageItem() { Title = "Home", Icon = "home.png", TargetType = typeof(Home) };
            var page2 = new MasterPageItem() { Title = "Sales", Icon = "sal.png", TargetType = typeof(Sales) };
            var page3 = new MasterPageItem() { Title = "Products", Icon = "prod.png", TargetType = typeof(Products) };
            var page4 = new MasterPageItem() { Title = "Customer", Icon = "customer.png", TargetType = typeof(Customer) };
            var page5 = new MasterPageItem() { Title = "Reports", Icon = "sss.png", TargetType = typeof(Reports) };
            var page6 = new MasterPageItem() { Title = "Setup", Icon = "setting.png", TargetType = typeof(Setup) };
            var page7 = new MasterPageItem() { Title = "Logout", Icon = "logout.png", TargetType = typeof(Logout) };
          //  var page8 = new MasterPageItem() { Title = "Categeory", Icon = "categeory.png",  TargetType = typeof(categoryForm) };

            //var page6 = new MasterPageItem() { Title = "Login", Icon = "bui.png", TargetType = typeof(Page3) };
            //var page7 = new MasterPageItem() { Title = "Register", Icon = "sim.png", TargetType = typeof(Page1) };
            //var page8 = new MasterPageItem() { Title = "MainScreen", Icon = "fire.png", TargetType = typeof(Page2) };
            //var page9 = new MasterPageItem() { Title = "MastersPage", Icon = "msg.png", TargetType = typeof(Page3) };

            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);
            menuList.Add(page7);
           // menuList.Add(page8);

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;
           
            // Initial navigation, this can be used for our home page



           Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Home)));

        }

        protected override bool OnBackButtonPressed()
        {
            // Do your magic here
            return true;
        }
        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            if (item.Title.Equals("Products"))
            {
                item = (MasterPageItem)e.SelectedItem;
                navigationDrawerList.IsVisible = false;
                menuList1 = new List<MasterPageItem>();

                // Creating our pages for menu navigation
                // Here you can define title for item, 
                // icon on the left side, and page that you want to open after selection
                var page1 = new MasterPageItem() {Icon1="prod.png", Title = "Product", TargetType=typeof(ProductDetails)};
                var page2 = new MasterPageItem() { Icon1="categeory.png", Title = "Categeory", TargetType = typeof(categoryForm) };
                var page3 = new MasterPageItem() { Icon1 = "departmnt.png", Title = "Department" };
                var page4 = new MasterPageItem() { Icon1 = "brand.png", Title = "Brand"};
                var page5 = new MasterPageItem() { Icon1 = "supply.png", Title = "Supplier"};
                var page6 = new MasterPageItem() { Icon1 = "tax.png", Title = "Tax" };
                var page7 = new MasterPageItem() {Icon1 = "recive.png", Title = "Receving/Returns" };

                //var page6 = new MasterPageItem() { Title = "Login", Icon = "bui.png", TargetType = typeof(Page3) };
                //var page7 = new MasterPageItem() { Title = "Register", Icon = "sim.png", TargetType = typeof(Page1) };
                //var page8 = new MasterPageItem() { Title = "MainScreen", Icon = "fire.png", TargetType = typeof(Page2) };
                //var page9 = new MasterPageItem() { Title = "MastersPage", Icon = "msg.png", TargetType = typeof(Page3) };

                // Adding menu items to menuList
                menuList1.Add(page1);
                menuList1.Add(page2);
                menuList1.Add(page3);
                menuList1.Add(page4);
                menuList1.Add(page5);
                menuList1.Add(page6);
                menuList1.Add(page7);
                //menuList.Add(page9);
                navigationDrawerList1.IsVisible = true;
                // Setting our list to be ItemSource for ListView in MainPage.xaml
                navigationDrawerList1.ItemsSource = menuList1;

                  Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Home)));

      


    }


            else
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                IsPresented = false;
            }



        }


        private void OnMenuItemSelectedproducts(object sender, SelectedItemChangedEventArgs ee)
        {

            var item = (MasterPageItem)ee.SelectedItem;
            Type page = item.TargetType;


            if (item.Title.Equals("Product"))
            {
                //Navigation.PushModalAsync(new ProductDetails());
                Detail = new ProductDetails();
                headertitle.Text = item.Title;
              

            }

        if (item.Title.Equals("Categeory"))
            {
               // Navigation.PushModalAsync(new categoryForm());

               Detail = new categoryForm();
                headertitle.Text = item.Title;

            }


            if (item.Title.Equals("Department"))
            {
                // Navigation.PushModalAsync(new categoryForm());

                Detail = new DeptForm();
                headertitle.Text = item.Title;

            }

            if (item.Title.Equals("Brand"))
            {
                // Navigation.PushModalAsync(new categoryForm());

                Detail = new BrandForm();
                headertitle.Text = item.Title;

            }


            if (item.Title.Equals("Tax"))
            {
                // Navigation.PushModalAsync(new categoryForm());

                Detail = new TaxForm();
                headertitle.Text = item.Title;

            }



            if (item.Title.Equals("Supplier"))
            {
                // Navigation.PushModalAsync(new categoryForm());

                Detail = new SupplierFormxaml();
                headertitle.Text = item.Title;


            }

        }

        public void back(Object o, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }



       







    }
}