using AppStore.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AppStore;

public partial class UserControl_Product : UserControl
{
    public List<ProductItems> Products { get; set; }

    public ProductItems Product { get; set; }

    decimal? count { get; set; }

    public UserControl_Product(ProductItems product, List<ProductItems> store)
    {
        InitializeComponent();



        Products = new();

        ProductName.Content = product.Product.Product_Name;
        Product_count.Content = product.Product_Count.ToString();
        Product_price.Content = product.Product_Price.ToString();
        image.ImageSource = new BitmapImage(new Uri(product.Product.Product_Image_Url!, UriKind.Relative));


        count = product.Product_Count;

        Product = product;
        Products = store;
    }

    private void addstore_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        var ChangedImageurl = @"../../../Images/accept.png";
        var SimpleUrl = @"../../../Images/add.png";



        if (addstore.IsChecked.Value == true)
        {
            Product_count.Content = (count - 1);
            image_button.ImageSource = new BitmapImage(new Uri(ChangedImageurl!, UriKind.Relative));
            Products.Add(Product);
        }

        else
        {
            Product_count.Content = count;
            image_button.ImageSource = new BitmapImage(new Uri(SimpleUrl!, UriKind.Relative));
            Products.Remove(Product);
        }


    }
}