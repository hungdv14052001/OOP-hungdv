using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_hung.dv.entity
{
    class Product : BaseRow
    {
        private int id;
        private string name;
        private int categoryId;
        private int quantity;
        private int price;
        private string image;
        private string describe;

        public Product()
        {

        }

        public Product(int id, string name, int categoryId, int quantity, int price, string image, string describe)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
            this.quantity = quantity;
            this.price = price;
            this.image = image;
            this.describe = describe;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public string Image { get => image; set => image = value; }
        public string Describe { get => describe; set => describe = value; }
    }
}
