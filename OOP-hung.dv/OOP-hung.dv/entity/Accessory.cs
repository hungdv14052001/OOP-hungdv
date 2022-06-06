using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.entity
{
    class Accessory : BaseRow, iEntity
    {

        //Phương thức khởi tạo Accessory không tham số
        public Accessory()
        {
        }

        //Phương thức khởi tạo Accessory có tham số
        public Accessory(int id, string name) : base(id, name)
        {
        }
    }
}
