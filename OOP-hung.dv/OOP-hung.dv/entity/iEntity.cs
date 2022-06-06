using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.entity
{
    internal interface iEntity
    {
        //Mô tả phương thức get, set Id
        public int Id { get; set; }

        //Mô tả phương thức get, set Name
        public string Name { get; set; }
    }
}
