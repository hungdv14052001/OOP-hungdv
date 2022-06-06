using OOP_hung.dv.dao;
using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.demo
{
    class CategoryDaoDemo
    {
        private CategoryDAO categoryDAO;
        
        public CategoryDaoDemo()
        {
            categoryDAO = new CategoryDAO();
        }
        public void insertTest()
        {
            Category category = new Category(1, "Computer");
            Console.WriteLine(categoryDAO.insert(category));
            Category category2 = new Category(2, "Laptop");
            categoryDAO.insert(category);
        }
        public void updateTest()
        {
            Category category = new Category(1, "Linh Kien");
            categoryDAO.update(category);
        }
        public void deleteTest()
        {
            Category category = new Category(1, "Linh Kien");
            categoryDAO.delete(category);
        }
        public void findAllTest()
        {
            List<Category> listCategory = categoryDAO.findAll();
            foreach(Category category in listCategory)
            {
                Console.WriteLine("Id: " + category.Id + "\nName: " + category.Name);
            }
        }
        public void findByIdTest()
        {
            int id = 1;
            Category category = categoryDAO.findById(id);
            Console.WriteLine("Id: " + category.Id + "\nName: " + category.Name);
        }
    }
}
