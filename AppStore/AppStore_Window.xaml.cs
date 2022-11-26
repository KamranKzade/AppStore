using AppStore.Models;
using System.Linq;
using AppStore.UserControls;
using System.Collections.Generic;
using System.Windows;

namespace AppStore;


public partial class AppStore_Window : Window
{
    public List<ProductItems> ProductItems { get; set; }


    public AppStore_Window(List<ProductItems> products)
    {
        InitializeComponent();


        foreach (var product in products)
        {
            UserControl_AppStore user = new UserControl_AppStore(product);
            bombaStackPanel.Children.Add(user);
        }

        ProductItems = products;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var sum = ProductItems.Sum(s => s.Product_Price * 1);
        MessageBox.Show($"Sizin Ödəyəcəyiniz məbləğ: {sum}", "Cash", MessageBoxButton.OK, MessageBoxImage.Exclamation);
    }
}