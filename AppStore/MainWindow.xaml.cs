using AppStore.Models;
using System.Collections.Generic;
using System.Windows;

namespace AppStore;




public partial class MainWindow : Window
{
    public List<ProductItems> Products { get; set; }
    public List<ProductItems> Store_Products { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        Products = new();
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

        foreach (var item in Store_Products)
        {
            MessageBox.Show($"{item.Product.Product_Name}");
        }


        //if (Store_Products.Count > 0)
        //{
        //    AppStore_Button_Click app = new AppStore_Button_Click(Store_Products);
        //    app.ShowDialog();
        //}
        //else
        //    MessageBox.Show("Səbətdə məhsul yoxdur!!!", "Information", MessageBoxButton.OK, MessageBoxImage.Exclamation);


    }



}
