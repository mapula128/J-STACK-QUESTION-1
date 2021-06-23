using System;
using System.Collections.Generic;
using System.Text;

namespace j_stack_Question_1
{
    class ProductSellOder : Store
    {
        //declarstion of constractor
        public ProductSellOder()
        {
            Console.WriteLine("see our sales in store");
        }

        //  public void ProductSell
        public void SellProductsFromInventory()
        {


            string Day = DateTime.Today.ToString("hh:mm:ss");
            string nextDay = DateTime.Today.ToString("HH:d:ss");


            var currentDay = DateTime.Now.ToString("hh:mm:ss");

          
            int numOfItemsToSell = 0;
            double pricePerItem = 0;
            double totalAmountOfItemsSold = 0;
            int totalNumOfLaptopsSold = 0;
            int totalNumOfTabletsSold = 0;
            int totalNumOfPhonessSold = 0;
            double costPerPerchase = 0;
           
            int numOfItemsPerPurchase = 0;
           
            int productsInStock = 0;
            int productsToSell = 0;

            string[] itemsStoreSells = new string[3] { "Laptops", "Tablets", "Phones" };
            Console.WriteLine("what is the Item summary you would like to get?");

            foreach (string item in itemsStoreSells)
            {
                switch (item)
                {
                    case "Laptops":
                        if (Day == currentDay)
                        {

                            
                                if ((Laptops > 0) && (productsInStock >= productsToSell))
                                {



                                    costPerPerchase=pricePerItem * numOfItemsToSell;

                                    totalNumOfLaptopsSold += numOfItemsPerPurchase;
                                    totalAmountOfItemsSold += costPerPerchase;
                                    Console.WriteLine("you have bought ", totalNumOfLaptopsSold);
                                    Console.Read();// making application wait 
                                }

                            if (totalNumOfLaptopsSold == 3)

                            {
                                costPerPerchase = 9000;
                                Console.WriteLine("You have a discount,you only going to pa", costPerPerchase);
                            }
                        }
                        else if (Day == nextDay)
                        {
                            if (totalNumOfLaptopsSold == 4)
                            {
                                costPerPerchase =8500;
                                Console.WriteLine("You got yourself a discount ,only spending", costPerPerchase);
                            }
                            Console.Read();// making application wait 
                        }





                        break;
                    case "Tablets":
                        if (Day == currentDay)
                        {

                            if ((Tablets> 0) && (productsInStock >= productsToSell))
                            {
                                costPerPerchase = pricePerItem * numOfItemsToSell;

                                totalNumOfTabletsSold += numOfItemsPerPurchase;
                                totalAmountOfItemsSold += costPerPerchase;
                                Console.WriteLine("you have bought ", totalNumOfTabletsSold);
                                
                            }

                            if (totalNumOfTabletsSold == 8)

                            {
                                costPerPerchase = 8000;
                                Console.WriteLine("You have a discount,you only going to purchase", costPerPerchase);
                            }
                        }
                        else if (Day == nextDay)
                        {
                            if (totalNumOfTabletsSold == 6)
                            {
                                costPerPerchase = 7000;
                                Console.WriteLine("You got yourself a discount ,only spending", costPerPerchase);
                            }
                            Console.Read();// making application wait 
                        }


                      
                        break;

                    case "Phones":

                        if (Day == currentDay) {
                            if ((Phones> 0) && (productsInStock >= productsToSell))
                            {

                                costPerPerchase = pricePerItem * numOfItemsToSell;

                                totalNumOfPhonessSold += numOfItemsPerPurchase;
                                totalAmountOfItemsSold += costPerPerchase;
                                Console.WriteLine("you have bought ", totalNumOfPhonessSold);
                            }

                            if (totalNumOfPhonessSold == 10)

                            {
                                costPerPerchase = 10000;
                                Console.WriteLine("You have a discount,you only going to pa", costPerPerchase);
                            }
                        } else if (Day == nextDay)
                        {
                            if (totalNumOfPhonessSold == 12) {
                                costPerPerchase = 10000;
                                Console.WriteLine("You got yourself a discount ,only spending", costPerPerchase);
                            }
                            Console.Read();// making application wait 
                        }
                        
                        break;
                    default:
                        Console.WriteLine("We are out of Stock,ckeck with us in few days");
                        break;
                }

               
            }
           
            Console.WriteLine("We Have Sold :", totalNumOfLaptopsSold, "number of items this time.");
            Console.WriteLine("We Have Sold :", totalNumOfPhonessSold, "number of items this time.");
            Console.WriteLine("We Have Sold :", totalNumOfTabletsSold, "number of items this time.");
        }
    }
}
