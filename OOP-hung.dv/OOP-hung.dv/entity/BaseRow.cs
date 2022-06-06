using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.entity
{
    abstract class BaseRow
    {
        public BaseRow()
        {

        }
        protected int Id{ get; set; }
        protected string Name { get; set; }

    }
}
