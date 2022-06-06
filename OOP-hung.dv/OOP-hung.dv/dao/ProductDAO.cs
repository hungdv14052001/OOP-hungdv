using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.dao
{
    class ProductDAO : BaseDAO
    {
        private Database database;
        
        public ProductDAO()
        {
            database = Database.getInstants();
        }

        public bool insert(Product product)
        {
            try
            {
                database.insertTable("Product", product);
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
        }
        public bool update(Product product)
        {
            try
            {
                database.updateTable("Product", product);
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
        }
        public bool delete(Product product)
        {
            try
            {
                database.deleteTable("Product", product);
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
        }
        public List<Product> findAll()
        {
            List<Product> listProduct = new List<Product>();
            List<BaseRow> listObject = database.selectTable("Product");
            for (int i = 0; i < listObject.Count; i++)
            {
                Product product = listObject[i] as Product;
                listProduct.Add(product);
            }
            return listProduct;
        }
        public Product findById(int id)
        {
            Product result = new Product();
            List<BaseRow> listObject = database.selectTable("Product");
            for (int i = 0; i < listObject.Count; i++)
            {
                Product product = listObject[i] as Product;
                if (product.Id == id)
                {
                    result = product;
                }
            }
            return result;
        }
        public Product findByName(string name)
        {
            Product result = new Product();
            List<BaseRow> listObject = database.selectTable("Product");
            for (int i = 0; i < listObject.Count; i++)
            {
                Product product = listObject[i] as Product;
                if (product.Name.Equals(name))
                {
                    result = product;
                }
            }
            return result;
        }
    }
}
