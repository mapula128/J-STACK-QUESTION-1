using System;
using System.Collections.Generic;
using System.Text;

namespace j_stack_Question_1
{
    class InventorySummary
    {
        public void GetInventorySummary()
        {
            int numItemsPerPurchase = 0;

            string Day = DateTime.Today.ToString("hh:mm:ss");

            var currentDay = DateTime.Now.ToString("hh:mm:ss");

            //products in store at anytime


            //current items in store

            Store Laptops = new Store()
            {
                ItemName = "Acer",
                pricePerProduct = 3000,
                NumItems = 13



            };
            Store Tablets = new Store()
            {

                ItemName = "Mobicel",
                pricePerProduct = 1000,
                NumItems = 20

            };
            Store Phones = new Store()
            {


                ItemName = "IPhone7",
                pricePerProduct = 15000,
                NumItems = 9


            };
            //displaying product instore at anytime

            List<Store> products = new List<Store>(2);
            products.Add(Laptops);
            products.Add(Tablets);
            products.Add(Phones);

            //using foreach loop to loop throw the product type in  list/get summary of everything
            foreach (Store item in products)
            {


                if (Day == currentDay)
                {


                   
                    Console.WriteLine("ItemName={0}, pricePerProduct={1}, NumItems={2}", item.ItemName, item.pricePerProduct * numItemsPerPurchase, item.NumItems);


                    Console.WriteLine("Itemame={0}, pricePerProduct={1}, NumItems={2}", item.ItemName, item.pricePerProduct * numItemsPerPurchase, item.NumItems);

                    Console.WriteLine("ItemName={0}, pricePerProduct={1}, NumItems={2}", item.ItemName, item.pricePerProduct * numItemsPerPurchase, item.NumItems);

                }

            }


            
        }
    }
        

    }

