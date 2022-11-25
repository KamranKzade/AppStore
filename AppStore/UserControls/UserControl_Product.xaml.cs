﻿using AppStore.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AppStore;

public partial class UserControl_Product : UserControl
{
    public List<Product> Products { get; set; }

    public Product Product { get; set; }

    public UserControl_Product(Product product, List<Product> products)
    {
        InitializeComponent();

        Products = new();

        ProductName.Content = product.Product_Name;
        Product_count.Content = product.Product_Count.ToString();
        Product_price.Content = product.Product_Price.ToString();
        image.ImageSource = new BitmapImage(new Uri(product.Product_Image_Url!, UriKind.Relative));


        Product = product;
        Products = products;
    }

    private void addstore_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        var ChangedImageurl = @"../../../Images/accept.png";
        var SimpleUrl = @"../../../Images/add.png";


        if (addstore.IsChecked.Value == true)
            image_button.ImageSource = new BitmapImage(new Uri(ChangedImageurl!, UriKind.Relative));


        else
            image_button.ImageSource = new BitmapImage(new Uri(SimpleUrl!, UriKind.Relative));


        Products.Add(Product);
    }
}