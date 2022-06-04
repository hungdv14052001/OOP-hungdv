using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.entity
{
    class Category
    {
        private int id;
        private string name;

        public Category()
        {

        }

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
