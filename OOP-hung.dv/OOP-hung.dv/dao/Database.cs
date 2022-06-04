﻿using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace OOP_hung.dv.dao
{
    class Database
    {
        private List<Product> productTable;
        private List<Category> categoryTable;
        private List<Accessory> accessoryTable;
        private Database instants;

        public Database()
        {
            productTable = new List<Product>();
            categoryTable = new List<Category>();
            accessoryTable = new List<Accessory>();
        }


        public int insertTable(string name, Object row)
        {
            int result = 0;
            if (name.Equals("productTable"))
            {
                try
                {
                    Product product = row as Product;
                    productTable.Add(product);
                    result = 1;
                }
                catch
                {

                }

            }
            else if (name.Equals("categoryTable"))
            {
                try
                {
                    Category category = row as Category;
                    categoryTable.Add(category);
                    result = 2;
                }
                catch
                {

                }

            }
            else if (name.Equals("accessoryTable"))
            {
                try
                {
                    Accessory accessory = row as Accessory;
                    accessoryTable.Add(accessory);
                    result = 3;
                }
                catch
                {

                }
            }
            return result;
        }

        public List<Object> selectTable(string name)
        {
            List<Object> objectList = new List<object>();
            if (name.Equals("productTable"))
            {
                for (int i = 0; i < productTable.Count; i++)
                {
                    objectList.Add(productTable[i]);
                }
            }
            else if (name.Equals("categoryTable"))
            {
                for (int i = 0; i < categoryTable.Count; i++)
                {
                    objectList.Add(categoryTable[i]);
                }
            }
            else if (name.Equals("accessoryTable"))
            {
                for (int i = 0; i < accessoryTable.Count; i++)
                {
                    objectList.Add(accessoryTable[i]);
                }
            }
            return objectList;
        }
        public int updateTable(string name, Object row)
        {
            int result = 0;
            if (name.Equals("productTable"))
            {
                Product product = row as Product;
                for (int i = 0; i < productTable.Count; i++)
                {
                    if (productTable[i].Id == product.Id)
                    {
                        productTable[i].Name = product.Name;
                        productTable[i].CategoryId = product.CategoryId;
                        productTable[i].Quantity = product.Quantity;
                        productTable[i].Price = product.Price;
                        productTable[i].Image = product.Image;
                        productTable[i].Describe = product.Describe;
                    }
                }
                result = 1;
            }
            else if (name.Equals("categoryTable"))
            {
                Category category = row as Category;
                for (int i = 0; i < categoryTable.Count; i++)
                {
                    if (categoryTable[i].Id == category.Id)
                    {
                        productTable[i].Name = category.Name;
                    }
                }
                result = 2;
            }
            else if (name.Equals("accessoryTable"))
            {
                Accessory accessory = row as Accessory;
                for (int i = 0; i < accessoryTable.Count; i++)
                {
                    if (accessoryTable[i].Id == accessory.Id)
                    {
                        accessoryTable[i].Name = accessory.Name;
                    }
                }
                result = 3;
            }
            return result;
        }
        public int deleteTable(string name, Object row)
        {
            int result = 0;
            if (name.Equals("productTable"))
            {
                Product product = row as Product;
                for (int i = 0; i < productTable.Count; i++)
                {
                    if (productTable[i].Id == product.Id)
                    {
                        productTable.Remove(productTable[i]);
                    }
                }
                result = 1;
            }
            else if (name.Equals("categoryTable"))
            {
                Category category = row as Category;
                for (int i = 0; i < categoryTable.Count; i++)
                {
                    if (categoryTable[i].Id == category.Id)
                    {
                        categoryTable.Remove(categoryTable[i]);
                    }
                }
                result = 2;
            }
            else if (name.Equals("accessoryTable"))
            {
                Accessory accessory = row as Accessory;
                for (int i = 0; i < accessoryTable.Count; i++)
                {
                    if (accessoryTable[i].Id == accessory.Id)
                    {
                        accessoryTable.Remove(accessoryTable[i]);
                    }
                }
                result = 3;
            }
            return result;
        }
        public void truncateTable(string name)
        {
            if (name.Equals("productTable"))
            {
                productTable.Clear();
            }
            else if (name.Equals("categoryTable"))
            {
                categoryTable.Clear();
            }
            else if (name.Equals("accessoryTable"))
            {
                accessoryTable.Clear();
            }
        }
        public int updateTableById(int id, Object row)
        {
            int result = 0;
            try
            {
                Product product = row as Product;
                result = 1;
                for (int i = 0; i < productTable.Count; i++)
                {
                    if (productTable[i].Id == product.Id)
                    {
                        productTable[i].Name = product.Name;
                        productTable[i].CategoryId = product.CategoryId;
                        productTable[i].Quantity = product.Quantity;
                        productTable[i].Price = product.Price;
                        productTable[i].Image = product.Image;
                        productTable[i].Describe = product.Describe;
                    }
                }
                result = 1;
            }
            catch
            {

            }
            try
            {
                Category category = row as Category;
                for (int i = 0; i < categoryTable.Count; i++)
                {
                    if (categoryTable[i].Id == category.Id)
                    {
                        productTable[i].Name = category.Name;
                    }
                }
                result = 2;
            }
            catch
            {

            }
            try
            {
                Accessory accessory = row as Accessory;
                for (int i = 0; i < accessoryTable.Count; i++)
                {
                    if (accessoryTable[i].Id == accessory.Id)
                    {
                        accessoryTable[i].Name = accessory.Name;
                    }
                }
                result = 3;
            }
            catch
            {

            }
            return result;
        }
    }
}