using OOP_hung.dv.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.dao
{
    class AccessoryDAO : BaseDAO
    {
        private Database database;
        public AccessoryDAO()
        {
            database = Database.getInstants();
        }
        public bool insert(Accessory accessory)
        {
            try
            {
                database.insertTable("Accessory", accessory);
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
        }
        public bool delete(Accessory accessory)
        {
            try
            {
                database.deleteTable("Accessory", accessory);
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
        }
        public bool update(Accessory accessory)
        {
            try
            {
                database.updateTable("Accessory", accessory);
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
        }
        public List<Accessory> findAll()
        {
            List<Accessory> listAccessory = new List<Accessory>();
            List<BaseRow> listObject = database.selectTable("Accessory");
            for (int i = 0; i < listObject.Count; i++)
            {
                Accessory accessory = listObject[i] as Accessory;
                listAccessory.Add(accessory);
            }
            return listAccessory;
        }
        public Accessory findById(int id)
        {
            Accessory result = new Accessory();
            List<BaseRow> listObject = database.selectTable("Accessory");
            for (int i = 0; i < listObject.Count; i++)
            {
                Accessory accessory = listObject[i] as Accessory;
                if (accessory.Id == id)
                {
                    result = accessory;
                }
            }
            return result;
        }
        public Accessory findByName(string name)
        {
            Accessory result = new Accessory();
            List<BaseRow> listObject = database.selectTable("Accessory");
            for (int i = 0; i < listObject.Count; i++)
            {
                Accessory accessory = listObject[i] as Accessory;
                if (accessory.Name.Equals(name))
                {
                    result = accessory;
                }
            }
            return result;
        }
    }
}
