using System;
namespace ProgrammingAssignment8._1
{
    //'Part' class inherits attributes of StockItem
    public class Part : StockItem
    {
        //allowing for additional details to be added to a 'part' entry
        private string comment { get; set; }

        public Part()
        {

        }
        //"type", "name", "brand", "price", quantity", "partDetails"
        public Part(string _itemType, string _name, string _brand, string _price, string _quantity, string partDetails)
        {

            itemType = _itemType;

            name = _name;

            brand = _brand;

            price = _price;

            quantity = _quantity;

            comment = partDetails;

        }

        public Part(Part _part)
        {
            itemType = _part.itemType;

            name = _part.name;

            brand = _part.brand;

            price = _part.price;

            quantity = _part.quantity;

            comment = _part.comment;

        }
        public override string ToString()
        {

            return "\n\tPart Name: " + name + "\n\tBrand: " + brand + "\n\tPrice: $" + price + "\n\tQuantity: " + quantity + "\n\tAdditional details: " + comment;


        }

    }
}
