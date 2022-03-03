namespace ProgrammingAssignment8._1
{

    //defining traits common to all  
    public class StockItem
    {

        public string itemType { get; set; }

        public string name { get; set; }

        public string brand { get; set; }

        public string price { get; set; }

        public string quantity { get; set; }

        public StockItem()
        {

        }

        public StockItem(string _itemType, string _name, string _brand,string _price, string _quantity)
        {

            itemType = _itemType;

            name = _name;

            brand = _brand;

            price = _price;

            quantity = _quantity;

        }

        public override string ToString()
        {

            return "\n\tProduct Name: " + name + "\n\tBrand: " + brand + "\n\tPrice: $" + price + "\n\tQuantity: " + quantity;

        }

    }
}