using System;
using System.Collections.Generic;
using static System.Console;

namespace ProgrammingAssignment8._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Greeting();

        }

        private static void Greeting()
        {

            WriteLine("\tWelcome!\n\n\tInventory Update:");
            DataEntryLoop();

        }

        private static void DataEntryLoop()
        {

            bool keepGoing = true;

            //inputData = reusable instance of UserInput class which contains attributes stockitemList, partList, bikeList to store data about different types of items
            UserInput inputData = new UserInput();

            while (keepGoing == true)
            {

                // Switch determining the appropriate method call for the information to be entered
                WriteLine("\n\tEnter 1 for bikes, 2 for parts, 3 for general accessories.");
                var type = ReadLine();

                switch (type)
                {

                    case "1":
                        BikeEntry(inputData);
                        break;

                    case "2":
                        PartEntry(inputData);
                        break;

                    case "3":
                        StockItemEntry(inputData);
                        break;

                        //ensuring user follows intended path
                    default:
                        WriteLine("\n\tPlease enter a character from among the options provided.");
                        break;

                }
                WriteLine("\n\tWould you like to enter another item? Press N to view the list of entries. Y/N ");
                var continueLoop = ReadLine();

                if (continueLoop == "Y" || continueLoop == "y")
                {


                    keepGoing = true;

                }

                else
                {

                    keepGoing = false;

                }

            }
            ReadInventory(inputData);

        }

        //method creating a Bike object to be stored in inputData.bikeList
        private static void BikeEntry(UserInput inputData)
        {

            var type = "Bike";

            WriteLine("\n\tPlease enter name of the model:");
            var name = ReadLine();

            WriteLine("\n\tPlease enter the manufacturer:");
            var brand = ReadLine();

            WriteLine("\n\tPlease enter the price:");
            var price = ReadLine();

            WriteLine("\n\tPlease enter the quantity in stock:");
            var quantity = ReadLine();

            WriteLine("\n\tPlease enter the frame size:");
            var bikeSize = ReadLine();

            var bike = new Bike(type, name, brand, price, quantity, bikeSize);
            inputData.bikeList.Add(bike);

            //WriteLine(inputData.bikeItemList[0].ToString());
            //ReadLine();

        }

        //method creating a Part object, stored in inputData.partList
        private static void PartEntry(UserInput inputData)
        {

            var type = "Part";

            WriteLine("\n\tPlease enter the name of the part:");
            var name = ReadLine();

            WriteLine("\n\tPlease enter the manufacturer:");
            var brand = ReadLine();

            WriteLine("\n\tPlease enter the price:");
            var price = ReadLine();

            WriteLine("\n\tPlease enter the quantity in stock:");
            var quantity = ReadLine();

            WriteLine("\n\tEnter any additional details here:");
            var partDetails = ReadLine();

            var part = new Part(type, name, brand, price, quantity, partDetails);
            inputData.partList.Add(part);

            //WriteLine(inputData.partList.ToString());
            //ReadLine();

        }

        //method creating a StockItem object, stored in inputData.StockItemList
        private static void StockItemEntry(UserInput inputData)
        {

            var type = "Misc. item";

            WriteLine("\n\tPlease enter the product name:");
            var name = ReadLine();

            WriteLine("\n\tPlease enter the manufacturer.");
            var brand = ReadLine();

            WriteLine("\n\tPlease enter the price.");
            var price = ReadLine();

            WriteLine("\n\tPlease enter the quantity in stock.");
            var quantity = ReadLine();

            var stockItem = new StockItem(type, name, brand, price, quantity);
            inputData.stockItemList.Add(stockItem);

            //WriteLine(inputData.partList[0].ToString());
            //ReadLine();

        }

        private static void ReadInventory(UserInput inputData)
        {

            if (inputData.bikeList.Count > 0)
            {
                string type = inputData.bikeList[0].itemType;
                SayTheType(type);

                for (int i = 0; i < inputData.bikeList.Count; i++)
                {
                    WriteLine(inputData.bikeList[i].ToString());

                }

            }

            if (inputData.partList.Count > 0)
            {

                string type = inputData.partList[0].itemType;
                SayTheType(type);

                for (int i = 0; i < inputData.partList.Count; i++)
                {

                    WriteLine(inputData.partList[i].ToString());

                }
            }

            if (inputData.stockItemList.Count > 0)
            {

                string type = inputData.stockItemList[0].itemType;
                SayTheType(type);

                for (int i = 0; i < inputData.stockItemList.Count; i++)
                {

                    WriteLine(inputData.stockItemList[i].ToString());

                }
            }
            
            ExitStageLeft();

        }

        private static void SayTheType(string type)
        {

            WriteLine("\n\n\t{0}s:", type);

        }

        private static void ExitStageLeft()
        {

            WriteLine("\n\n\tPress any key to exit.");
            ReadKey();

        }
    }
}
