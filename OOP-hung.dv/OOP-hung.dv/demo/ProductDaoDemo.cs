using OOP_hung.dv.dao;
using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.demo
{
    class ProductDaoDemo
    {
        private ProductDAO productDAO;

        public ProductDaoDemo()
        {
            productDAO = new ProductDAO();
        }
        public void insertTest()
        {
            Product product1 = new Product(1, "CPU", 1, 100, 700, "product.jpg", "Mô tả sản phẩm");
            Product product2 = new Product(2, "RAM", 1, 99, 500, "product.jpg", "Mo ta san pham");
            productDAO.insert(product1);
            productDAO.insert(product2);
        }
        public void updateTest()
        {
            Product product = new Product(1, "ROM", 1, 100, 700, "product.jpg", "Mô tả sản phẩm");
            productDAO.update(product);
        }
        public void deleteTest()
        {
            Product product = new Product(1, "ROM", 1, 100, 700, "product.jpg", "Mô tả sản phẩm");
            productDAO.delete(product);
        }
        public void findAllTest()
        {
            List<Product> listProduct = productDAO.findAll();
            for (int i= 0; i < listProduct.Count;i++)
            {
                Console.WriteLine(new ProductDemo().printProduct(listProduct[i]));
            }
        }
        public void findByIdTest()
        {
            
        }
    }
}
