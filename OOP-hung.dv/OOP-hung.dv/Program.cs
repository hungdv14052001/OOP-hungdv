using OOP_hung.dv.dao;
using OOP_hung.dv.demo;
using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;

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
            databaseDemo.updateTableTest();
            databaseDemo.deleteTableTest();
            databaseDemo.truncateTableTest();
            databaseDemo.initDatabase();
            databaseDemo.printTableTest("productTable");

            //Test CategoryDAO
            //CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo();
            //categoryDaoDemo.insertTest();
            //categoryDaoDemo.findAllTest();
            //categoryDaoDemo.updateTest();
            //categoryDaoDemo.deleteTest();
            BaseDAO productDAO = new ProductDAO();
            BaseRow row = new Product(1, "CPU", 1, 10, 700, "image.jpg", "Mo ta san pham");
            BaseRow row2 = new Product(2, "CPU", 1, 10, 700, "image.jpg", "Mo ta san pham");
            BaseRow row3 = new Product(3, "CP", 1, 10, 700, "image.jpg", "Mo ta san pham");
            productDAO.insert(row);
            productDAO.insert(row2);
            productDAO.insert(row3);
            List<BaseRow> listProduct = productDAO.findByName("CPU");
            foreach(BaseRow r in listProduct)
            {
                Console.WriteLine(new ProductDemo().printProduct(r as Product));
            }
        }
    }
}
