using AppStore.Models;
using System.Collections.Generic;

namespace AppStore.Repository;



public class FakeData
{
    public static List<Product> GetProducts()
    {
        return new List<Product>()
        {
            new Product()
            {
                Product_Image_Url = "../../../Images/cola.png",
                Product_Name="Cola",
                Product_Price = 0.9M,
                Product_Count = 40
            },
            new Product()
            {
                 Product_Image_Url = "../../../Images/fanta.png",
                Product_Name="Fanta",
                Product_Price = 0.9M,
                Product_Count = 52
            },
            new Product()
            {
                 Product_Image_Url = "../../../Images/pepsi.png",
                Product_Name="Pepsi",
                Product_Price = 0.9M,
                Product_Count = 32
            },
            new Product()
            {
                Product_Image_Url = "../../../Images/snickers.png",
                Product_Name="Snickers",
                Product_Price = 1.2M,
                Product_Count = 28
            },
            new Product()
            {   Product_Image_Url = "../../../Images/mars.png",
                Product_Name="Mars",
                Product_Price = 1M,
                Product_Count = 18
            },
            new Product()
            {   Product_Image_Url = "../../../Images/bounty.png",
                Product_Name="Bounty",
                Product_Price = 1M,
                Product_Count = 18
            },
            new Product()
            {   Product_Image_Url = "../../../Images/redbull.png",
                Product_Name="Redbull",
                Product_Price = 3.2M,
                Product_Count = 25
            },
            new Product()
            {   Product_Image_Url = "../../../Images/bizon.png",
                Product_Name="Bizon",
                Product_Price = 1.2M,
                Product_Count = 30
            },
            new Product()
            {   Product_Image_Url = "../../../Images/hell.png",
                Product_Name="Hell",
                Product_Price = 2M,
                Product_Count = 19
            },
        };
    }
}