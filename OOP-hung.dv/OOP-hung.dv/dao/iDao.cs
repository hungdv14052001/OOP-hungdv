using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.dao
{
    internal interface iDao
    {
        //Mô tả phương thức insert Baserow vào DataBase với tham số truyền vào là BaseRow
        public bool insert(BaseRow row);

        //Mô tả phương thức update Baserow trong DataBase theo tham số truyền vào là BaseRow
        public bool update(BaseRow row);

        //Mô tả phương thức delete Baserow trong DataBase theo tham số truyền vào là BaseRow
        public bool delete(BaseRow row);

        //Mô tả phương thức find all Baserow 
        public List<BaseRow> findAll();

        //Mô tả phương thức tìm BaseRow theo tham số truyền vào là id
        public BaseRow findById(int id);

        //Mô tả phương thức tìm BaseRow theo tham số truyền vào là name
        public List<BaseRow> findByName(string name);
    }
}
