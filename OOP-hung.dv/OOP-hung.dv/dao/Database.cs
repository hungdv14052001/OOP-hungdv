using OOP_hung.dv.entity;
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
        private static Database instants = new Database();

        //Phương thức khởi tạo DataBase không tham số
        private Database()
        {
            productTable = new List<Product>();
            categoryTable = new List<Category>();
            accessoryTable = new List<Accessory>();
        }

        //Phương thức getInstants
        public static Database getInstants()
        {
            return instants;
        }

        //Phương thức insert BaseRow vào Database với các tham số truyền vào là name và BaseRow 
        public int insertTable(string name, BaseRow row)
        {
            int result = 0;
            if (name.Equals("Product"))
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

        //Phương thức lấy danh sách BaseRow theo tham số truyền vào là name
        public List<BaseRow> selectTable(string name)
        {
            List<BaseRow> objectList = new List<BaseRow>();
            if (name.Equals("Product"))
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

        //Phương thức Update BaseRow trong Database với các tham số truyền vào là name và BaseRow
        public int updateTable(string name, BaseRow row)
        {
            int result = 0;
            if (name.Equals("Product"))
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
            else if (name.Equals("Category"))
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
            else if (name.Equals("Accessory"))
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

        //Phương thức dalete BaseRow trong Database với các tham số truyền vào là name và BaseRow
        public int deleteTable(string name, BaseRow row)
        {
            int result = 0;
            if (name.Equals("Product"))
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
            else if (name.Equals("Category"))
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
            else if (name.Equals("Accessory"))
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

        //Phương thức xóa toàn bộ mảng trong DataBase
        public void truncateTable(string name)
        {
            if (name.Equals("Product"))
            {
                productTable.Clear();
            }
            else if (name.Equals("Category"))
            {
                categoryTable.Clear();
            }
            else if (name.Equals("Accessory"))
            {
                accessoryTable.Clear();
            }
        }

        //Phương thức Update BaseRow trong Database với các tham số truyền vào là id và BaseRow
        public int updateTableById(int id, BaseRow row)
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