using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.dao
{
    abstract class BaseDAO : iDao
    {
        private Database database = Database.getInstants();

        //Phương thức khởi tạo BaseDAO không tham số
        public BaseDAO()
        {
        }

        //Phương thức insert Baserow vào DataBase với tham số truyền vào là BaseRow
        public bool insert(BaseRow row)
        {
            try
            {
                database.insertTable(row.GetType().Name, row);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Phương thức update Baserow trong DataBase theo tham số truyền vào là BaseRow
        public bool update(BaseRow row)
        {
            try
            {
                database.updateTable(row.GetType().Name, row);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Phương thức delete Baserow trong DataBase theo tham số truyền vào là BaseRow
        public bool delete(BaseRow row)
        {
            try
            {
                database.deleteTable(row.GetType().Name, row);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Phương thức find all Baserow 
        public List<BaseRow> findAll()
        {
            string typeOfDAO = this.GetType().Name;
            List<BaseRow> listRow = database.selectTable(typeOfDAO.Remove(typeOfDAO.Length-3, 3));
            return listRow;
        }

        //Phương thức tìm BaseRow theo tham số truyền vào là id
        public BaseRow findById(int id)
        {
            string typeOfDAO = this.GetType().Name;
            BaseRow result;
            if (typeOfDAO.Equals("ProductDAO"))
            {
                result = new Product();
            }
            else if (typeOfDAO.Equals("CategoryDAO"))
            {
                result = new Category();
            }
            else
            {
                result = new Accessory();
            }
            List<BaseRow> listRow = database.selectTable(typeOfDAO.Remove(typeOfDAO.Length - 3, 3));
            for (int i = 0; i < listRow.Count; i++)
            {
                if (listRow[i].Id == id)
                {
                    result = listRow[i];
                }
            }
            return result;
        }

        //Phương thức tìm BaseRow theo tham số truyền vào là name
        public List<BaseRow> findByName(string name)
        {
            string typeOfDAO = this.GetType().Name;
            List<BaseRow> listResult = new List<BaseRow>();
            List<BaseRow> listRow = database.selectTable(typeOfDAO.Remove(typeOfDAO.Length - 3, 3));
            for (int i = 0; i < listRow.Count; i++)
            {
                if (listRow[i].Name.Equals(name))
                {
                    listResult.Add(listRow[i]);
                }
            }
            return listResult;
        }
    }
}
