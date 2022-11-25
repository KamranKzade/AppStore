using AppStore.Models;
using System.Collections.Generic;
using System.Windows;

namespace AppStore;




public partial class MainWindow : Window
{
    public List<Product> Products { get; set; }

    public MainWindow()
    {
        InitializeComponent();
        Products = new List<Product>();

        Products = Repository.FakeData.GetProducts();

        foreach (var product in Products)
        {
            UserControl_Product userControl = new UserControl_Product(product);

            
            uniformGrid.Children.Add(userControl);
        }


    }
}
