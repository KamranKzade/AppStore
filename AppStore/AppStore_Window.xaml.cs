using AppStore.Models;
using AppStore.UserControls;
using System.Collections.Generic;
using System.Windows;

namespace AppStore;



public partial class AppStore_Window : Window
{

    public AppStore_Window(List<ProductItems> products)
    {
        InitializeComponent();

        DataContext = products;
        foreach (var product in products)
        {
            UserControl_AppStore user = new UserControl_AppStore(product);
            bombaStackPanel.Children.Add(user);
        }

    }
}
