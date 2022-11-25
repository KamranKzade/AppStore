namespace AppStore.Models;

public class Product
{

    public string? Product_Image_Url { get; set; }
    public string? Product_Name { get; set; }




    public Product(string? product_Image_Url, string? product_Name)
    {
        Product_Image_Url = product_Image_Url;
        Product_Name = product_Name;
    }
}
