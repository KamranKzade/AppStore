using AppStore.Models;
using System.Collections.Generic;
using System.Windows;

namespace AppStore;




public partial class MainWindow : Window
{
    public List<Product> Products { get; set; }
    public List<Product> Store_Products { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        Products = new List<Product>();
        Store_Products = new();

        Products = Repository.FakeData.GetProducts();

        foreach (var product in Products)
        {
            UserControl_Product userControl = new UserControl_Product(product, Store_Products);

            
            uniformGrid.Children.Add(userControl);
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{Store_Products.Count}");
    }



}
