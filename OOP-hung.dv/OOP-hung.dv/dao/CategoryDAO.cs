using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.dao
{
    class CategoryDAO
    {
        private Database database;

        public CategoryDAO()
        {
            database = new Database();
        }
        public bool insert(Category category) 
        {
            try
            {
                database.insertTable("Category", category);
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
        }
        public bool update(Category category)
        {
            try
            {
                database.updateTable("Category", category);
                return true;
            }
            catch(Exception exc)
            {
                return false;
            }
        }
        public bool delete(Category category)
        {
            if(category!= null)
            {
                database.deleteTable("Category", category);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Category> findAll()
        {
            List<Category> listCategory = new List<Category>();
            List<Object> listObject = database.selectTable("Category");
            for (int i=0;i< listObject.Count; i++)
            {
                Category category = listObject[i] as Category;
                listCategory.Add(category);
            }
            return listCategory;
        }
        public Category findById(int id)
        {
            Category result = new Category();
            List<Object> listObject = database.selectTable("Category");
            for (int i = 0; i < listObject.Count; i++)
            {
                Category category = listObject[i] as Category;
                if (category.Id == id)
                {
                    result = category;
                }
            }
            return result;
        }
    }
}
