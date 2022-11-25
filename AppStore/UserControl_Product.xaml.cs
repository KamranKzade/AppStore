using AppStore.Models;
using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AppStore;

public partial class UserControl_Product : UserControl
{
    public UserControl_Product(Product product)
    {
        InitializeComponent();

        ProductName.Content = product.Product_Name;
        Product_count.Content = product.Product_Count.ToString();
        Product_price.Content = product.Product_Price.ToString();
        image.ImageSource = new BitmapImage(new Uri(product.Product_Image_Url!, UriKind.Relative));
    }



}