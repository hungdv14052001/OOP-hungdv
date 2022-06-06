using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.dao
{
    abstract class BaseDAO
    {
        public BaseDAO()
        {

        }
        public bool insert(BaseRow row)
        {
            return false;
        }
        public bool update(BaseRow row)
        {
            return false;
        }
        public bool delete(BaseRow row)
        {
            return false;
        }
        public List<BaseRow> findAll()
        {
            return null;
        }
        public BaseRow findById(int id)
        {
            return null;
        }
    }
}
