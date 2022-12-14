using AppStore.Models;
using System.Collections.Generic;

namespace AppStore.Repository;



public class FakeData
{
    public static List<ProductItems> GetProducts()
    {
        return new List<ProductItems>()
        {
            new ProductItems
            {
                Product = new Product ("../../../Images/cola.png", "Cola"),
                Product_Price = 0.9M,
                Product_Count = 40,

            },
            new ProductItems
            {
                Product = new Product("../../../Images/fanta.png", "Fanta"),
                Product_Count = 52,
                Product_Price = 0.9M,
            },
            new ProductItems
            {
                Product = new Product( "../../../Images/pepsi.png","Pepsi" ),
                Product_Price = 0.9M,
                Product_Count = 32
            },
            new ProductItems
            {
                Product = new Product( "../../../Images/sprite.png","Sprite" ),
                Product_Price = 0.9M,
                Product_Count = 48
            },
            new ProductItems
            {
                Product =new Product("../../../Images/snickers.png", "Snickers"),
                Product_Price = 1.2M,
                Product_Count = 28
            },
            new ProductItems
            {
                Product = new Product("../../../Images/alpengold.png", "Alpen Gold"),
                Product_Price = 1.8M,
                Product_Count = 26
            },
            new ProductItems
            {
                Product = new Product("../../../Images/bounty.png", "Bounty"),
                Product_Price = 1M,
                Product_Count = 18
            },
            new ProductItems
            {
                Product = new Product("../../../Images/mars.png", "Mars"),
                Product_Price = 1M,
                Product_Count = 76
            },
            new ProductItems
            {
                Product = new Product("../../../Images/redbull.png", "Redbull"),
                Product_Price = 3.2M,
                Product_Count = 25
            },
            new ProductItems
            {
                Product = new Product( "../../../Images/bizon.png","Bizon" ),
                Product_Price = 1.2M,
                Product_Count = 30
            },
            new ProductItems
            {
                Product = new Product("../../../Images/hell.png", "Hell"),
                Product_Price = 2M,
                Product_Count = 19
            },
            new ProductItems
            {
                Product = new Product("../../../Images/full.png", "Full"),
                Product_Price = 0.7M,
                Product_Count = 85
            },
            new ProductItems
            {
                Product = new Product("../../../Images/winston.png", "Winston"),
                Product_Price = 3.8M,
                Product_Count = 29
            },
            new ProductItems
            {
                Product = new Product("../../../Images/sobranie.png", "Sobranie"),
                Product_Price = 4.2M,
                Product_Count = 39
            },
            new ProductItems
            {
                Product = new Product("../../../Images/wintchester.png", "Winchester"),
                Product_Price = 2.8M,
                Product_Count = 48
            },
            new ProductItems
            {
                Product = new Product("../../../Images/kent.png", "Kent"),
                Product_Price = 3.8M,
                Product_Count = 19
            },
        };
    }
}