using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.entity
{
    class Product : BaseRow, iEntity
    {
        private int categoryId;
        private int quantity;
        private int price;
        private string image;
        private string describe;

        //Phương thức khởi tạo Product không tham số.
        public Product() : base()
        {

        }

        //Phương thức khởi tạo Product với tham số
        public Product(int id, string name, int categoryId, int quantity, int price, string image, string describe) : base(id, name)
        {
            this.categoryId = categoryId;
            this.quantity = quantity;
            this.price = price;
            this.image = image;
            this.describe = describe;
        }

        //Phương thức get set CategoryId
        public int CategoryId { get => categoryId; set => categoryId = value; }

        //Phương thức get set Quantity
        public int Quantity { get => quantity; set => quantity = value; }

        //Phương thức get set Price
        public int Price { get => price; set => price = value; }

        //Phương thức get set Image
        public string Image { get => image; set => image = value; }

        //Phương thức get set Describe
        public string Describe { get => describe; set => describe = value; }
    }
}
