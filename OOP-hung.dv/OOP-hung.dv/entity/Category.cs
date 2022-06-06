using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.entity
{
    class Category : BaseRow, iEntity
    {
        //Phương thức khởi tạo Category không tham số
        public Category() : base()
        {
        }

        //Phương thức khởi tạo Category có tham số
        public Category(int id, string name): base(id, name)
        {
        }
    }
}
