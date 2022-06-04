using OOP_hung.dv.dao;
using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.demo
{
    class DatabaseDemo
    {
        private Database database = new Database();
        public void insertTableTest()
        {
            Product product = new Product(1, "CPU", 1, 100, 700, "product.jpg", "Mô tả sản phẩm");
            Product product2 = new Product(2, "RAM", 1, 99, 500, "product.jpg", "Mo ta san pham");
            database.insertTable("productTable", product);
            database.insertTable("productTable", product2);
            Category category = new Category(1, "Computer");
            database.insertTable("categoryTable", category);
            Accessory accessory = new Accessory(1, "abc");
            database.insertTable("accessoryTable", accessory);
        }

        public void selectTableTest()
        {
            List<Product> listProduct = new List<Product>();
            foreach (Object ob in database.selectTable("productTable"))
            {
                listProduct.Add(ob as Product);
            }

            List<Category> listCategory = new List<Category>();
            foreach (Object ob in database.selectTable("categoryTable"))
            {
                listCategory.Add(ob as Category);
            }
            List<Accessory> listAccessory = new List<Accessory>();
            foreach (Object ob in database.selectTable("accessoryTable"))
            {
                listAccessory.Add(ob as Accessory);
            }
        }
        public void updateTableTest()
        {
            Product product = new Product(1, "CPU", 1, 99, 700, "product.jpg", "Mo ta san pham");
            database.updateTable("productTable", product);
            Category category = new Category(1, "Com");
            database.updateTable("categoryTable", category);
            Accessory accessory = new Accessory(1, "cba");
            database.updateTable("accessoryTable", accessory);
        }
        public void deleteTableTest()
        {
            Product product = new Product(2, "RAM", 1, 99, 500, "product.jpg", "Mo ta san pham");
            database.deleteTable("productTable", product);
            Category category = new Category(1, "Computer");
            database.deleteTable("categoryTable", category);
            Accessory accessory = new Accessory(1, "abc");
            database.deleteTable("accessoryTable", accessory);
        }
        public void truncateTableTest()
        {
            database.truncateTable("productTable");
        }
        public void initDatabase()
        {
            //Product
            Product product = new Product(1, "CPU", 1, 100, 700, "product.jpg", "Mô tả sản phẩm");
            database.insertTable("productTable", product);
            Product product2 = new Product(2, "RAM", 1, 99, 500, "product.jpg", "Mo ta san pham");
            database.insertTable("productTable", product2);
            Product product3 = new Product(3, "Screen", 1, 99, 500, "product.jpg", "Mo ta san pham");
            database.insertTable("productTable", product3);
            Product product4 = new Product(4, "Card", 1, 99, 500, "product.jpg", "Mo ta san pham");
            database.insertTable("productTable", product4);
            Product product5 = new Product(5, "Mouse", 1, 99, 500, "product.jpg", "Mo ta san pham");
            database.insertTable("productTable", product5);
            Product product6 = new Product(6, "Keyboard", 1, 99, 500, "product.jpg", "Mo ta san pham");
            database.insertTable("productTable", product6);
            Product product7 = new Product(7, "Micro", 1, 99, 500, "product.jpg", "Mo ta san pham");
            database.insertTable("productTable", product7);
            Product product8 = new Product(8, "Main", 1, 99, 500, "product.jpg", "Mo ta san pham");
            database.insertTable("productTable", product8);
            Product product9 = new Product(9, "Rom", 1, 99, 500, "product.jpg", "Mo ta san pham");
            database.insertTable("productTable", product9);
            Product product10 = new Product(10, "VGA", 1, 99, 500, "product.jpg", "Mo ta san pham");
            database.insertTable("productTable", product10);

            //Category
            Category category1 = new Category(1, "Computer");
            database.insertTable("categoryTable", category1);
            Category category2 = new Category(1, "Computer");
            database.insertTable("categoryTable", category2);
            Category category3 = new Category(1, "Computer");
            database.insertTable("categoryTable", category3);
            Category category4 = new Category(1, "Computer");
            database.insertTable("categoryTable", category4);
            Category category5 = new Category(1, "Computer");
            database.insertTable("categoryTable", category5);
            Category category6 = new Category(1, "Computer");
            Category category7 = new Category(1, "Computer");
            database.insertTable("categoryTable", category6);
            database.insertTable("categoryTable", category7);
        }
        public void printTableTest(string name)
        {
            if (name.Equals("productTable"))
            {
                for(int i= 0; i< database.selectTable("productTable").Count; i++)
                {
                    Product product = database.selectTable("productTable")[i] as Product;
                    Console.WriteLine(new ProductDemo().printProduct(product));
                }
            }
            else if (name.Equals("categoryTable"))
            {
                for (int i = 0; i < database.selectTable("categoryTable").Count; i++)
                {
                    Category category = database.selectTable("categoryTable")[i] as Category;
                    Console.WriteLine("Id: " + category.Id + "\nName: " + category.Name);
                }
            }
            else if (name.Equals("accessoryTable"))
            {
                for (int i = 0; i < database.selectTable("accessoryTable").Count; i++)
                {
                    Accessory accessory= database.selectTable("accessoryTable")[i] as Accessory;
                    Console.WriteLine("Id: "+ accessory.Id+ "\nName: "+ accessory.Name);
                }
            }
        }
    }
}
