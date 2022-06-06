using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.dao
{
    class CategoryDAO : BaseDAO
    {
        private Database database;

        public CategoryDAO()
        {
            database = Database.getInstants();
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
            try
            {
                database.deleteTable("Category", category);
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
        }
        public List<Category> findAll()
        {
            List<Category> listCategory = new List<Category>();
            List<BaseRow> listObject = database.selectTable("Category");
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
            List<BaseRow> listObject = database.selectTable("Category");
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
