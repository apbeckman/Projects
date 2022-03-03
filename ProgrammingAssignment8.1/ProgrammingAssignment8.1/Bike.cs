using System;
namespace ProgrammingAssignment8._1
{
    public class Bike : StockItem
    {

       //public string bikeType { get; set; }

        public string bikeSize { get; set; }

        public Bike()
        {

        }

        public Bike(string _itemType, string _name, string _brand, string _price, string _quantity , string _bikeSize)
        {

            itemType = _itemType;

            name = _name;

            brand = _brand;

            price = _price;

            quantity = _quantity;

            bikeSize = _bikeSize;

        }

        public Bike(Bike _bike)
        {

            itemType = _bike.itemType;

            name = _bike.name;

            brand = _bike.brand;

            price = _bike.price;

            quantity = _bike.quantity;

            bikeSize = _bike.bikeSize;

        }

        public override string ToString()
        {

            return "\n\tProduct Name: " + name + "\n\tBrand: " + brand + "\n\tPrice: $" + price + "\n\tquantity: " + quantity + "\n\tSize: " + bikeSize;

        }
    }
}
