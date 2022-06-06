using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.entity
{
    abstract class BaseRow
    {
        private int id;
        private string name;

        //Phương thức tạo BaseRow không tham số
        public BaseRow()
        {

        }

        //Phương thức khởi tạo BaseRow có tham số
        public BaseRow(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        //Phương thức get, set Id
        public int Id { get => id; set => id = value; }

        //Phương thức get, set Name
        public string Name { get => name; set => name = value; }
    }
}
