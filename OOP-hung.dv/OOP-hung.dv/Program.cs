using OOP_hung.dv.demo;
using OOP_hung.dv.entity;
using System;

namespace OOP_hung.dv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test ProductDemo
            //ProductDemo productDemo = new ProductDemo();
            //Product product1 = productDemo.createProduct();
            //Product product2 = productDemo.createProduct(1, "CPU", 1, 100, 700, "product.jpg", "Mô tả sản phẩm");
            //Product product3 = new Product();
            //Console.WriteLine(productDemo.printProduct(product1));
            //Console.WriteLine(productDemo.printProduct(product2));
            //Console.WriteLine(productDemo.printProduct(product3));

            //Test DatabaseDemo

            DatabaseDemo databaseDemo = new DatabaseDemo();
            databaseDemo.insertTableTest();
            databaseDemo.selectTableTest();
            //databaseDemo.updateTableTest();
            //databaseDemo.deleteTableTest();
            //databaseDemo.truncateTableTest();
            //databaseDemo.initDatabase();
            //databaseDemo.printTableTest("productTable");

            //Test CategoryDAO
            //CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo();
            //categoryDaoDemo.insertTest();
            //categoryDaoDemo.findAllTest();
            //categoryDaoDemo.updateTest();
            //categoryDaoDemo.deleteTest();
        }
    }
}
