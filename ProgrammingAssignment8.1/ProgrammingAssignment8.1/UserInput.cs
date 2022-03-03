using System;
using System.Collections.Generic;
namespace ProgrammingAssignment8._1
{
    public class UserInput: StockItem
    {

        public List<StockItem> stockItemList { get; set; }

        public List<Part> partList { get; set; }

        public List<Bike> bikeItemList { get; set; }

        public UserInput()
        {

            partList = new List<Part>();

            stockItemList = new List<StockItem>();

            bikeItemList = new List<Bike>();

        }
        
    }
}
