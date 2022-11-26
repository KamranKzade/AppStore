using AppStore.Models;
using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AppStore.UserControls;


public partial class UserControl_AppStore : UserControl
{
    public UserControl_AppStore(ProductItems product)
    {
        InitializeComponent();

        image.ImageSource = new BitmapImage(new Uri(product.Product.Product_Image_Url!, UriKind.Relative));
        ProductName.Content = product.Product.Product_Name;
        Product_price.Content = product.Product_Price.ToString();

    }
}
