using AppStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace AppStore;




public partial class MainWindow : Window
{
    public List<ProductItems> Products { get; set; }
    public List<ProductItems> Store_Products { get; set; }

    public ProductItems EditProduct { get; set; }



    public MainWindow()
    {
        InitializeComponent();

        Products = new();
        Store_Products = new();
        EditProduct = new();


        Products = Repository.FakeData.GetProducts();

        foreach (var product in Products)
        {
            UserControl_Product userControl = new UserControl_Product(product, Store_Products);


            uniformGrid.Children.Add(userControl);

            userControl.MouseDoubleClick += UserControl_MouseDoubleClick;
        }
    }

    private void UserControl_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        var product = sender as UserControl_Product;


        Edit_Window edit = new(EditProduct);


        edit.ProductName.Content = product!.Product.Product!.Product_Name;
        edit.Product_image.ImageSource = new BitmapImage(new Uri(product.Product.Product.Product_Image_Url!, UriKind.Relative));
        edit.Product_count.Text = product.Product.Product_Count.ToString();
        edit.Product_price.Text = product.Product.Product_Price.ToString();

        edit.ShowDialog();

        product.Product_price.Text = edit.Product_price.Text.ToString();
        product.Product_count.Text = edit.Product_count.Text.ToString();
        product.Product_count.IsEnabled = false;
        product.Product_count.IsEnabled = false;




        foreach (var item in Products)
        {
            if (item.Product.Product_Name == product.Product.Product.Product_Name)
            {
                item.Product_Price = decimal.Parse(product.Product_price.Text);
                item.Product_Count = decimal.Parse(product.Product_count.Text);
            }
        }

    }





    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (Store_Products.Count > 0)
        {
            AppStore_Window app = new AppStore_Window(Store_Products);
            app.ShowDialog();
        }
        else
            MessageBox.Show("Səbətdə məhsul yoxdur!!!", "Information", MessageBoxButton.OK, MessageBoxImage.Exclamation);
    }

    private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                foreach (var control in uniformGrid.Children.OfType<UserControl_Product>())
                    control.Visibility = Visibility.Visible;

                return;
            }


            foreach (var control in uniformGrid.Children.OfType<UserControl_Product>())
            {
                if (!control.Product.Product!.Product_Name!.ToLower().Contains(txtSearch.Text.ToLower()))
                    control.Visibility = Visibility.Collapsed;
            }
        }

    }
}