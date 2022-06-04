using System;
using System.Collections.Generic;
using System.Text;
using OOP_hung.dv.entity;

namespace OOP_hung.dv.demo
{
    class ProductDemo
    {
        public Product createProduct()
        {
            Product product = new Product(1,"CPU", 1, 100, 700, "product.jpg", "Mô tả sản phẩm");
            return product;
        }
        public Product createProduct(int id, string name, int categoryId, int quantity, int price, string image, string describe)
        {
            Product product = new Product();
            product.Id = id;
            product.Name = name;
            product.CategoryId = categoryId;
            product.Quantity = quantity;
            product.Price = price;
            product.Image = image;
            product.Describe = describe;
            return product;
        }
        public string printProduct(Product product)
        {
            return "Id: " + product.Id + "\nName: " + product.Name + "\nCategoryId: " + product.CategoryId + "\nQuantity: " + product.Quantity+ "\nPrice: " + product.Price+ "\nImage: " + product.Image + "\nDescribe: " + product.Describe;
        }
    }
}
