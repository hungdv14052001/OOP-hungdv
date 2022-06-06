using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.dao
{
    public interface iDao
    {
        public bool insert()
        {
            return false;
        }
        public bool update()
        {
            return false;
        }
        public bool delete()
        {
            return false;
        }
        public List<Object> findAll()
        {
            return null;
        }
        public Object findById()
        {
            return null;
        }
    }
}
