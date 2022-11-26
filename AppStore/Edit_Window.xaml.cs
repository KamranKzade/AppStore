using AppStore.Models;
using System;
using System.Windows;

namespace AppStore;

public partial class Edit_Window : Window
{
    public ProductItems product { get; set; }


    public Edit_Window(ProductItems gelen)
    {
        InitializeComponent();
        product = new ProductItems();
        product = gelen;
    }



    private void addstore_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            product.Product_Price = decimal.Parse(Product_price.Text);
            product.Product_Count = decimal.Parse(Product_count.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex}", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }



        DialogResult = true;
    }
}